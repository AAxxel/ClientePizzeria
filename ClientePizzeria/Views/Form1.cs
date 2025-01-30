using ClientePizzeria.Models;
using ClientePizzeria.Services;
using ClientePizzeria.Data;

namespace ClientePizzeria
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            bool validacion = ValidationHelper.ValidateInputsRegistro(textBoxUserName.Text, textBoxEmail.Text, textBoxPassWord.Text, comboBoxRoles.SelectedIndex);
            if (!validacion)
            {
                return;
            }

            CreateUser user = new CreateUser()
            {
                NombreUsuario = textBoxUserName.Text,
                Email = textBoxEmail.Text,
                Telefono = textBoxTelefono.Text,
                idRol = comboBoxRoles.SelectedIndex,
                Password = textBoxPassWord.Text
            };

            try
            {
                var result = await ApiServices.postData<CreateUser>("Usuario/agregar-usuario", user);

                if (result != null)
                {
                    MessageBox.Show("Usuario registrado con éxito.");
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();

        }


    }
}
