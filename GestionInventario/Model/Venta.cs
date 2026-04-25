using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionInventario.Model
{
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public double Total
        {
            get { return Detalles.Sum(d => d.Subtotal); }
        }
    }
}
