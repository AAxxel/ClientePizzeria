using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using ClientePizzeria.Models;
using ClientePizzeria.Services;
using POSPizzeria.DTOs;

namespace Controllers
{
    public  class PedidoController 
    {
        public PedidoController()
        {

        }
        public async Task<List<Pedido>> LoadPedido()
        {
            
            try
            {
                var pedidos = await ApiServices.getData<List<Pedido>>("Pedido/obtener-pedidos");

                if (pedidos == null)
                {
                    MessageBox.Show("Error: "+ pedidos);
                    return default;
                }
                else
                {
                    
                    return pedidos;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pedidos: {ex.Message}");
                return default;
            }
        }

        public async Task<Pedido> realizarPedido(CreatePedido data)
        {

            try
            {
                var pedido = await ApiServices.realizarPedidoService("Pedido/crear-pedido", data);

                if (pedido == null)
                {
                    MessageBox.Show("No se guardo. Intente de nuevo: " + pedido);
                    return default;
                }
                else
                {
                    return pedido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar pedido: {ex.Message}");
                return default;
            }
        }

    }
}
