using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using ClientePizzeria.Models;
using ClientePizzeria.Services;

namespace Controllers
{
    public  class DireccionController 
    {
        public DireccionController()
        {

        }
        public async Task<List<DireccionClienteResponse>> LoadDireccion()
        {
            
            try
            {
                var direcciones = await ApiServices.getData<List<DireccionClienteResponse>>("DireccionCliente/obtener-direcciones-clientes");

                if (direcciones == null)
                {
                    MessageBox.Show("Error: "+ direcciones);
                    return default;
                }
                else
                {
                    
                    return direcciones;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las direcciones: {ex.Message}");
                return default;
            }
        }

        public async Task<List<DireccionClienteResponse>> LoadDireccionByCliente(int idCliente)
        {

            try
            {
                var direcciones = await ApiServices.getData<List<DireccionClienteResponse>>($"DireccionCliente/obtener-direcciones-cliente/{idCliente}");

                if (direcciones == null)
                {
                    MessageBox.Show("Error: " + direcciones);
                    return default;
                }
                else
                {

                    return direcciones;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las direcciones: {ex.Message}");
                return default;
            }
        }

        public async Task<DireccionClienteResponse> AgregarDireccion(DireccionClienteResponse data)
        {

            try
            {
                var direccion = await ApiServices.postData<DireccionClienteResponse>("DireccionCliente/agregar-direccion-cliente", data);

                if (direccion == null)
                {
                    MessageBox.Show("No se guardo. Intente de nuevo: " + direccion);
                    return default;
                }
                else
                {
                    return direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar direccion: {ex.Message}");
                return default;
            }
        }

        public async Task<DireccionClienteResponse> UpdateDireccion(DireccionClienteResponse data)
        {

            try
            {
                var direccion = await ApiServices.putData<DireccionClienteResponse>("DireccionCliente/editar-direccion-cliente", data);

                if (direccion == null)
                {
                    MessageBox.Show("No se edito. Intente de nuevo: "+ direccion);
                    return default;
                }
                else
                {
                    return direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar direccion: {ex.Message}");
                return default;
            }
        }

    }
}
