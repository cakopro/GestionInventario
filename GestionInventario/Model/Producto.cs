using System;

namespace GestionInventario.Model
{
    public class Producto
    {
        
        public int Id { get; set; }

        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }

       
        public string ProveedorAsociado { get; set; }

        
        public Producto() { }

        public Producto(int id, string nombre, double precio, int cantidad, string proveedorAsociado, DateTime fecha)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.ProveedorAsociado = proveedorAsociado;
            this.FechaIngreso = fecha;
        }
    }
}