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

namespace ClientePizzeria.Views
{
    public partial class Producto : Form
    {
        ProductoController productoControler;
        ProductoResponse updateProducto;
        public Producto()
        {
            InitializeComponent();
            productoControler = new ProductoController();
            updateProducto = new ProductoResponse();
            cargarProductos();
        }

        private void panel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = panel.Rows[e.RowIndex];

                inputNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
                inputPrecio.Text = filaSeleccionada.Cells[2].Value.ToString();
                inputImpuesto.Text = filaSeleccionada.Cells[3].Value.ToString();
                inputCategoria.Text = filaSeleccionada.Cells[4].Value.ToString();
                inputProveedor.Text = filaSeleccionada.Cells[5].Value.ToString();
                

                updateProducto.IdProducto = Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());

            }
        }

        private async void buttonEditar_Click(object sender, EventArgs e)
        {
            updateProducto.NombreProducto = inputNombre.Text;
            updateProducto.PrecioProducto = Convert.ToDecimal(inputPrecio.Text);
            updateProducto.Impuesto = Convert.ToDecimal(inputImpuesto.Text);
            updateProducto.IdCategoria = Convert.ToInt32(inputCategoria.Text);
            updateProducto.IdProveedor = Convert.ToInt32(inputProveedor.Text);


            var user = await productoControler.UpdateProducto(updateProducto);
            if (user == null)
            {

                return;
            }
            else
            {
                cargarProductos();
            }
        }

        private async void cargarProductos()
        {
            panel.Rows.Clear();
            panel.Refresh();
            List<ProductoResponse> list = await productoControler.LoadProducto();
            if (list != null)
            {
                foreach (var l in list)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(panel);
                    row.Cells[0].Value = l.IdProducto;
                    row.Cells[1].Value = l.NombreProducto;
                    row.Cells[2].Value = l.PrecioProducto;
                    row.Cells[3].Value = l.Impuesto;
                    row.Cells[4].Value = l.Stock;
                    row.Cells[5].Value = l.IdCategoria;
                    row.Cells[6].Value = l.IdProveedor;
                    panel.Rows.Add(row);
                }
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            updateProducto.NombreProducto = inputNombre.Text;
            updateProducto.PrecioProducto = Convert.ToDecimal(inputPrecio.Text);
            updateProducto.Impuesto = Convert.ToDecimal(inputImpuesto.Text);
            updateProducto.IdCategoria = Convert.ToInt32(inputCategoria.Text);
            updateProducto.IdProveedor = Convert.ToInt32(inputProveedor.Text);
            updateProducto.Stock = 0;

            var user = await productoControler.AgregarProducto(updateProducto);
            if (user == null)
            {
                return;
            }
            else
            {
                cargarProductos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }
    }
}