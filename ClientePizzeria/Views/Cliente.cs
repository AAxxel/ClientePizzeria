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
    public partial class Cliente : Form
    {
        ClienteController clienteController;
        ResponseClient updateCliente;
        public Cliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            updateCliente = new ResponseClient();
            cargarCliente();

        }

        private async void buttonEditar_Click(object sender, EventArgs e)
        {
            updateCliente.NombreCliente = inputName.Text;
            updateCliente.Email = inputEmail.Text;
            updateCliente.Telefono = inputTelefono.Text;

            var user = await clienteController.UpdateCliente(updateCliente);
            if (user == null)
            {

                return;
            }
            else
            {
                cargarCliente();
            }

        }

        private async void cargarCliente()
        {
            panel.Rows.Clear();
            panel.Refresh();
            List<ResponseClient> list = await clienteController.LoadCliente();

            if (list != null)
            {
                foreach (var l in list)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(panel);
                    row.Cells[0].Value = l.idCliente;

                    row.Cells[1].Value = l.NombreCliente;
                    row.Cells[3].Value = l.Email;
                    row.Cells[2].Value = l.Telefono;


                    panel.Rows.Add(row);
                }
            }

        }

        private void panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = panel.Rows[e.RowIndex];


                inputName.Text = filaSeleccionada.Cells[1].Value.ToString();
                inputEmail.Text = filaSeleccionada.Cells[3].Value.ToString();
                inputTelefono.Text = filaSeleccionada.Cells[2].Value.ToString();

                updateCliente.idCliente = Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            updateCliente.NombreCliente = inputName.Text;
            updateCliente.Email = inputEmail.Text;
            updateCliente.Telefono = inputTelefono.Text;

            var user = await clienteController.AgregarCliente(updateCliente);
            if (user == null)
            {

                return;
            }
            else
            {
                cargarCliente();
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
