using System;
using System.Collections.Generic;
using System.Text;

namespace GestionInventario.Model
{
    internal class ProductoFinal
    {
        int id;
        string nombre;
        double precio;
        private List<string> ingredientes;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public List<string> Ingredientes { get => ingredientes; set => ingredientes = value; }

        public ProductoFinal(int id, string nombre, double precio, List<string> ingredientes)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            Ingredientes = ingredientes;
        }

        
    }
}
