using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadElementos { get; set; }
        public string FechaIngreso { get; set; }
        public double PrecioMinimo { get; set; }
        public double PrecioMaximo { get; set; }
    }
}
