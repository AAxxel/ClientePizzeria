using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePizzeria.Models
{
    public class User
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rol { get; set; }

    }

    public class CreateUser
    {
        public int idRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Password { get; set; }

    }

    public class UserResponse
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }

    public class UpdateUser
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }
}
