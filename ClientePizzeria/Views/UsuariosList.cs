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
using ClientePizzeria.Services;
using Controllers;
using ClientePizzeria.Data;



namespace ClientePizzeria
{
    public partial class UsuariosList : Form
    {
        UsuarioController usuarioControler;
        UserResponse updateUser;
        public UsuariosList()
        {
            InitializeComponent();
            usuarioControler = new UsuarioController();
            updateUser = new UserResponse();
            cargarUsuarios();
        }

        private async void buttonEditar_Click(object sender, EventArgs e)
        {

            updateUser.idRol = Convert.ToInt32(inputRol.Text);
            updateUser.NombreUsuario = inputName.Text;
            updateUser.Email = inputEmail.Text;
            updateUser.Telefono = inputTelefono.Text;

            var user = await usuarioControler.UpdateUsers(updateUser);
            if (user == null)
            {
                return;
            }
            else
            {
                cargarUsuarios();
            }

        }


        private async void cargarUsuarios()
        {
            panel.Rows.Clear();
            panel.Refresh();
            List<UserResponse> list = await usuarioControler.LoadUsers();
            if (list != null)
            {
                foreach (var l in list)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(panel);
                    row.Cells[0].Value = l.idUsuario;
                    row.Cells[1].Value = l.idRol;
                    row.Cells[2].Value = l.NombreUsuario;
                    row.Cells[3].Value = l.Email;
                    row.Cells[4].Value = l.Telefono;


                    panel.Rows.Add(row);
                }
            }

        }

        private void panel_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = panel.Rows[e.RowIndex];

                inputRol.Text = filaSeleccionada.Cells[1].Value.ToString();
                inputName.Text = filaSeleccionada.Cells[2].Value.ToString();
                inputEmail.Text = filaSeleccionada.Cells[4].Value.ToString();
                inputTelefono.Text = filaSeleccionada.Cells[3].Value.ToString();

                updateUser.idUsuario = Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());

            }
        }

        private void panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            updateUser.idRol = Convert.ToInt32(inputRol.Text);
            updateUser.NombreUsuario = inputName.Text;
            updateUser.Email = inputEmail.Text;
            updateUser.Telefono = inputTelefono.Text;

            var user = await usuarioControler.AgregarCliente(updateUser);
            if (user == null)
            {
                return;
            }
            else
            {
                cargarUsuarios();
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
