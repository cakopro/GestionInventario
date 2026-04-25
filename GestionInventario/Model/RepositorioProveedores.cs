using System;
using System.Collections.Generic;
using System.Text;

namespace GestionInventario.Model
{
    public class RepositorioProveedores
    {
        private static List<Proveedores> proveedores = new List<Proveedores>();

        public void agregar(Proveedores provedor)
        {
            int ultimoId = 0;
            if (proveedores.Count > 0)
            {
                ultimoId = proveedores[proveedores.Count - 1].Id;
            }

            provedor.Id = ultimoId + 1;
            proveedores.Add(provedor);
            
        }

        public Proveedores obtenerPorId(int id)
        {
            foreach (Proveedores p in proveedores)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void eliminar(int id)
        {
            Proveedores proveedor = obtenerPorId(id);
            if (proveedor != null)
            {
                proveedores.Remove(proveedor);
            }
        }

        public List<Proveedores> obtenerTodo()
        {
            return proveedores;
        }

        
    }
}
