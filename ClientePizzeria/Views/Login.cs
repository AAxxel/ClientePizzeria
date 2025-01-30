using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientePizzeria.Data;
using ClientePizzeria.Models;
using ClientePizzeria.Services;
using ClientePizzeria.Views;

namespace ClientePizzeria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Form1 registro = new Form1();
            registro.Show();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            bool validacion = ValidationHelper.ValidateInputsLogin (textBoxUserName.Text, textBoxPassWord.Text);
            if (!validacion)
            {
                return;
            }

            Auth auth = new Auth()
            {
                usuario = textBoxUserName.Text,
                Clave = textBoxPassWord.Text
            };

            try
            {
                var result = await ApiServices.postLogin("Auth/login", auth);

                if (result != null)
                {
                    MessageBox.Show("Login exitoso.");
                    ApiServices.SetAuthorizationToken(result.Token);

                    if (result.usuario.rol == "Cajero")
                    {
                        POS pos = new POS(result.usuario.id);
                        pos.Show();
                    }
                    else
                    {
                        Home home = new Home();
                        home.Show();
                        
                    }

                    Hide();

                }
                else
                {
                    MessageBox.Show("Error al entrar. Intente de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
