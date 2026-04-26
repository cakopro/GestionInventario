using System;
using System.Windows.Forms;
using GestionInventario.Model;
using System.Linq;  

namespace GestionInventario.views
{
    public partial class FormProductos : Form
    {

        RepositorioProductos repoProductos = new RepositorioProductos();

        public FormProductos()
        {
            InitializeComponent();
            ActualizarTabla();
        }


        private void ActualizarTabla()
        {
            dgvProductos.DataSource = null;
          
            dgvProductos.DataSource = repoProductos.obtenerTodo().ToList();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

            FormDetalleProducto ventana = new FormDetalleProducto();
            ventana.ShowDialog();


            ActualizarTabla();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            if (dgvProductos.CurrentRow != null)
            {

                int id = (int)dgvProductos.CurrentRow.Cells[0].Value;


                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    repoProductos.eliminar(id);
                    ActualizarTabla();
                    MessageBox.Show("Producto eliminado con exito.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {

            if (dgvProductos.CurrentRow != null)
            {

                int id = (int)dgvProductos.CurrentRow.Cells[0].Value;
                Producto productoSeleccionado = repoProductos.obtenerPorId(id);


                FormDetalleProducto ventana = new FormDetalleProducto(productoSeleccionado);
                ventana.ShowDialog();


                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            
            FormDetalleProducto ventana = new FormDetalleProducto();
            ventana.ShowDialog(); 

            
            ActualizarTabla();
        }
    }
}