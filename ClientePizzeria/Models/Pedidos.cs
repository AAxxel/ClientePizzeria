using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientePizzeria.Models;

namespace ClientePizzeria.Models
{
    public class DetallePedidoDTO
    {
        public int IdDetalle { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}

namespace POSPizzeria.DTOs
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdDireccionCliente { get; set; }
        public decimal? Total { get; set; }
        public List<DetallePedidoDTO> Detalles { get; set; } = new List<DetallePedidoDTO>();
    }
    public class CreatePedido
    {
        public int IdEmpleado { get; set; }
        public int IdDireccionCliente { get; set; }
        public List<CreateDetallePedido> Detalles { get; set; } = new List<CreateDetallePedido>();
    }

    public class CreateDetallePedido
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }

}
