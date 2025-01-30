using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientePizzeria.Models;
using Controllers;
using POSPizzeria.DTOs;

namespace ClientePizzeria.Views
{
    public partial class POS : Form
    {
        ProductoController productoControler;
        ClienteController clienteController;
        DireccionController direccionController;
        PedidoController pedidoController;

        List<ProductoResponse> listaProducto;
        List<ResponseClient> listaClientes;
        List<DireccionClienteResponse> listaDirecciones;
        List<CreateDetallePedido> listaDetallePedidos;

        private decimal? calculoTotal = 0;

        private int _idUsuario;

        public POS(int idUsuario)
        {
            productoControler = new ProductoController();
            clienteController = new ClienteController();
            direccionController = new DireccionController();
            pedidoController = new PedidoController();

            listaProducto = new List<ProductoResponse>();
            listaClientes = new List<ResponseClient>();
            listaDirecciones = new List<DireccionClienteResponse>();
            listaDetallePedidos = new List<CreateDetallePedido>();

            _idUsuario = idUsuario;

            InitializeComponent();
            cargarComboboxes();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDireccion.SelectedIndex == -1 || comboBoxCliente.SelectedIndex == -1 || comboBoxProducto.SelectedIndex == -1 || inputCantidad.Text == null)
            {
                MessageBox.Show("Faltan datos.");
                return;
            }

            ProductoResponse p = listaProducto.Where(l => l.IdProducto == Convert.ToInt32(comboBoxProducto.SelectedValue)).First();
            ResponseClient c = listaClientes.Where(l => l.idCliente == Convert.ToInt32(comboBoxCliente.SelectedValue)).First();
            DireccionClienteResponse d = listaDirecciones.Where(l => l.IdDireccion == Convert.ToInt32(comboBoxDireccion.SelectedValue)).First();
            int cantNum = Convert.ToInt32(inputCantidad.Text);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(panel);
            row.Cells[0].Value = panel.RowCount;

            row.Cells[1].Value = p.NombreProducto;
            row.Cells[2].Value = p.PrecioProducto;
            row.Cells[3].Value = cantNum;
            row.Cells[4].Value = p.PrecioProducto * cantNum;

            panel.Rows.Add(row);

            CreateDetallePedido nuevoDetalle = new CreateDetallePedido()
            {
                Cantidad = cantNum,
                IdProducto = p.IdProducto
            };

            listaDetallePedidos.Add(nuevoDetalle);

            calculoTotal += p.PrecioProducto * cantNum;
            labelNumero.Text = calculoTotal.ToString();
        }

        public async void cargarComboboxes()
        {
            listaProducto = await productoControler.LoadProducto();
            comboBoxProducto.DataSource = listaProducto;
            comboBoxProducto.DisplayMember = "NombreProducto";
            comboBoxProducto.ValueMember = "idProducto";

            listaClientes = await clienteController.LoadCliente();
            comboBoxCliente.DataSource = listaClientes;
            comboBoxCliente.DisplayMember = "NombreCliente";
            comboBoxCliente.ValueMember = "idCliente";

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private async void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedValue == null)
            {
                return;
            }
            int index = comboBoxCliente.SelectedIndex;

            listaDirecciones = await direccionController.LoadDireccionByCliente(index);
            comboBoxDireccion.DataSource = listaDirecciones;
            comboBoxDireccion.DisplayMember = "Direccion";
            comboBoxDireccion.ValueMember = "idDireccion";
        }

        private async void buttonCobrar_Click(object sender, EventArgs e)
        {
            int direccionFinal = listaDirecciones
                        .Where(l => l.IdDireccion == Convert.ToInt32(comboBoxDireccion.SelectedValue))
                        .Select(l => l.IdDireccion) 
                        .FirstOrDefault();

            CreatePedido createPedido = new CreatePedido()
            {
                IdEmpleado = 1,
                IdDireccionCliente = 10,
                Detalles = listaDetallePedidos
            };

            Pedido facturFinal = await pedidoController.realizarPedido(createPedido);
            MessageBox.Show("Total a pagar: " + facturFinal.Total);
            POS newPos = new POS(_idUsuario);
            newPos.Show();
            Close();


        }
    }
}
