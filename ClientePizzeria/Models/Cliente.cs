using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePizzeria.Models
{
    public class Cliente
    {
        public int idUser { get; set; }
        public string nombre { get; set; }
        public string rol { get; set; }

    }

    public class CreateCliente
    {
        
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
       

    }

    public class ResponseClient
    {
        public int idCliente { get; set; }
        
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }

    public class UpdateCliente
    {
        public int idCliente { get; set; }
        
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }
}
