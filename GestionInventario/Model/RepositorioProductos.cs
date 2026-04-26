using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionInventario.Model
{
    public class RepositorioProductos
    {
        
        private static List<Producto> productos = new List<Producto>();

       
        public void agregar(Producto producto)
        {
            int ultimoId = 0;
            if (productos.Count > 0)
            {
               
                ultimoId = productos.Max(p => p.Id);
            }

            producto.Id = ultimoId + 1;
            productos.Add(producto);
        }

       
        public List<Producto> obtenerTodo()
        {
            return productos;
        }

     
        public Producto obtenerPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

      
        public void eliminar(int id)
        {
            Producto producto = obtenerPorId(id);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
    }
}