using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePizzeria.Models
{
        public class ProductoResponse
        {
            public int IdProducto { get; set; }
            public string? NombreProducto { get; set; }
            public decimal? PrecioProducto { get; set; }
            public decimal? Impuesto { get; set; }
            public int? Stock { get; set; }
            public int? IdCategoria { get; set; }
            public int? IdProveedor { get; set; }
        }

        public class CreateProducto
        {
            public string? NombreProducto { get; set; }
            public decimal? PrecioProducto { get; set; }
            public decimal? Impuesto { get; set; }
            public int? Stock { get; set; }
            public int? IdCategoria { get; set; }
            public int? IdProveedor { get; set; }
        }

        public class UpdateProducto
        {
            public int IdProducto { get; set; }
            public string? NombreProducto { get; set; }
            public decimal? PrecioProducto { get; set; }
            public decimal? Impuesto { get; set; }
            public int? Stock { get; set; }
            public int? IdCategoria { get; set; }
            public int? IdProveedor { get; set; }
        }

}
