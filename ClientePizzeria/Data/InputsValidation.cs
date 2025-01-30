using System;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;

namespace ClientePizzeria.Data
{
    public static class ValidationHelper
{
    public static bool ValidateInputsRegistro(string userName, string email, string password, int roleIndex)
    {

        if (string.IsNullOrWhiteSpace(userName))
        {
            MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
        {
            MessageBox.Show("Por favor ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        if (roleIndex == -1)
        {
            MessageBox.Show("Por favor seleccione un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
        public static bool ValidateInputsLogin(string userName, string password)
        {

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




        private static bool IsValidEmail(string email)
    {
        try
        {
            var mailAddress = new MailAddress(email);
            return mailAddress.Address == email;
        }
        catch
        {
            return false;
        }
    }

        public static bool objetoVaciosVerificar<T>(T obj)
        {
            if (obj == null) return true; 

            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj); 

                if (value == null) return true;

                if (value is string strValue && string.IsNullOrWhiteSpace(strValue))
                    return true; 
            }

            return false; 
        }
    }



}