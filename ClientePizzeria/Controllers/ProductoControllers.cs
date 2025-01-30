using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using ClientePizzeria.Models;
using ClientePizzeria.Services;

namespace Controllers
{
    public  class ProductoController 
    {
        public ProductoController()
        {

        }
        public async Task<List<ProductoResponse>> LoadProducto()
        {
            
            try
            {
                var Productos = await ApiServices.getData<List<ProductoResponse>>("Producto/obtener-productos");

                if (Productos == null)
                {
                    MessageBox.Show("Error: "+ Productos);
                    return default;
                }
                else
                {
                    
                    return Productos;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
                return default;
            }
        }

        public async Task<ProductoResponse> AgregarProducto(ProductoResponse data)
        {

            try
            {
                var Producto = await ApiServices.postData<ProductoResponse>("Producto/agregar-producto", data);

                if (Producto == null)
                {
                    MessageBox.Show("No se guardo. Intente de nuevo: " + Producto);
                    return default;
                }
                else
                {
                    return Producto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}");
                return default;
            }
        }

        public async Task<ProductoResponse> UpdateProducto(ProductoResponse data)
        {

            try
            {
                var usuario = await ApiServices.putData<ProductoResponse>("Producto/editar-producto", data);

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
