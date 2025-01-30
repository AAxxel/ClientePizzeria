using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePizzeria.Models
{
    public class DireccionClienteResponse
    {
        public int IdDireccion { get; set; }
        public int? IdCliente { get; set; }
        public string? Direccion { get; set; }
    }

    public class CreateDireccionCliente
    {
        public int? IdCliente { get; set; }
        public string? Direccion { get; set; }
    }

    public class UpdateDireccionCliente
    {
        public int IdDireccion { get; set; }
        public int? IdCliente { get; set; }
        public string? Direccion { get; set; }
    }


    public class DeleteDireccionCliente
    {
        public int IdDireccion { get; set; }
    }
}
