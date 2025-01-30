using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePizzeria.Models
{
    public class AuthResponse
    {
        public string Message { get; set; }
        public string Token { get; set; }
        public User usuario { get; set; }
    }

    public class Auth
    {
        public string Clave { get; set; }
        public string usuario { get; set; }
    }
}
