using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientePizzeria.Views;

namespace ClientePizzeria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void usuariosOptions_Click(object sender, EventArgs e)
        {
            UsuariosList usuariosList = new UsuariosList();
            usuariosList.Show();
            Hide();

        }

        private void clientesOptions_Click(object sender, EventArgs e)
        {
            Cliente clienteList = new Cliente();
            clienteList.Show();
            Hide();
        }

        private void pedidosOptions_Click(object sender, EventArgs e)
        {
            Producto productoList = new Producto();
            productoList.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
