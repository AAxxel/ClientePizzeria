using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientePizzeria.Services;
using ClientePizzeria.Models;
using System.Security.Cryptography.X509Certificates;

namespace Controllers
{
    public  class UsuarioController 
    {
        public UsuarioController()
        {

        }
        public async Task<List<UserResponse>> LoadUsers()
        {
            
            try
            {
                var usuarios = await ApiServices.getData<List<UserResponse>>("Usuario/obtener-usuarios");

                if (usuarios == null)
                {
                    return default;
                }
                else
                {
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
                return default;
            }
        }

        public async Task<UserResponse> AgregarUsuario(UserResponse data)
        {

            try
            {
                MessageBox.Show("Nombre: " + data.NombreUsuario + "email: " + data.Email + "telefono: " + data.Telefono);
                var usuario = await ApiServices.postData<UserResponse>("Usuario/agregar-usuario", data);

                if (usuario == null)
                {
                    MessageBox.Show("No se guardo. Intente de nuevo: " + usuario);
                    return default;
                }
                else
                {
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}");
                return default;
            }
        }

        public async Task<UserResponse> UpdateUsers(UserResponse data)
        {
            MessageBox.Show(data.Email);

            try
            {
                var usuario = await ApiServices.putData<UserResponse>("Usuario/editar-usuario", data);

                if (usuario == null)
                {
                    MessageBox.Show("No se edito. Intente de nuevo: "+ usuario);
                    return default;
                }
                else
                {
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
                return default;
            }
        }

    }
}
