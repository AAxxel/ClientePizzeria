using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientePizzeria.Services;
using ClientePizzeria.Models;
using System.Security.Cryptography.X509Certificates;

namespace Controllers
{
    public  class ClienteController 
    {
        public ClienteController()
        {

        }
        public async Task<List<ResponseClient>> LoadCliente()
        {
            
            try
            {
                var clientes = await ApiServices.getData<List<ResponseClient>>("Cliente/obtener-clientes");

                if (clientes == null)
                {
                    MessageBox.Show("Error: "+ clientes);
                    return default;
                }
                else
                {
                    
                    return clientes;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
                return default;
            }
        }

        public async Task<ResponseClient> AgregarCliente(ResponseClient data)
        {

            try
            {
                var cliente = await ApiServices.postData<ResponseClient>("Cliente/agregar-cliente", data);

                if (cliente == null)
                {
                    MessageBox.Show("No se guardo. Intente de nuevo: " + cliente);
                    return default;
                }
                else
                {
                    return cliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}");
                return default;
            }
        }

        public async Task<ResponseClient> UpdateCliente(ResponseClient data)
        {

            try
            {
                var usuario = await ApiServices.putData<ResponseClient>("Cliente/editar-cliente", data);

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
                MessageBox.Show($"Error al editar usuario: {ex.Message}");
                return default;
            }
        }

    }
}
