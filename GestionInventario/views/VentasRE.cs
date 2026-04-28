using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionInventario.Model;

namespace GestionInventario.views
{
    public partial class VentasRE : Form
    {
        List<DetalleVenta> detallesActuales = new List<DetalleVenta>();
        List<Venta> listaVentas = new List<Venta>();
        List<ProductoFinal> catalogo = new List<ProductoFinal>(); 

        public VentasRE()
        {
            InitializeComponent();
            cargarCatalogo();
        }

        void ActualizarDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detallesActuales;
        }

        void cargarCatalogo()
        {
            //catologo para tener productos que vender . estos tienen una lista de ingredientes la cual esta previamente creada en ventana princ
            catalogo.Add(new ProductoFinal(1,"Especial", 3500, new List<string> { "pan", "vienesa" }));
            catalogo.Add(new ProductoFinal(2,"Hamburguesa con queso", 4500, new List<string> { "pan hamburguesa", "hamburguesa", "queso" }));
            cmbProductos.DataSource = catalogo;
            cmbProductos.DisplayMember = "Nombre";
            txtPrecio.ReadOnly = true;
            txtPrecio.BackColor = System.Drawing.Color.LightGray;
        }

        void CalcularTotal()
        {
            double total = detallesActuales.Sum(d => d.Subtotal);
            lblTotal.Text = "Total: $" + total.ToString("N0");
        }

        void ActualizarVentas()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaVentas.Select(v => new
            {
                Fecha = v.Fecha,
                Productos = string.Join(" | ", v.Detalles.Select(d => $"{d.Cantidad}x {d.Producto}")),
                Total = v.Total
            }).ToList();

            if (dgvVentas.Columns["Productos"] != null)
                dgvVentas.Columns["Productos"].Width = 300;
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //valida que se seleciones algo en cmb y que no este vacio cantidad. precio no se ingresa oslo se muestra
            if (cmbProductos.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            try
            {
                //instancia un producto final en base a lo seleccionado en cmb
                ProductoFinal platoSeleccionado = (ProductoFinal)cmbProductos.SelectedItem;
                int cantidadPedida = int.Parse(txtCantidad.Text);
                //crea una lista de productos en la cual ya viene los productos creados debido a que es static y los datos no cambiar
                RepositorioProductos repoP = new RepositorioProductos();
                var listaInsumosGlobal = repoP.obtenerTodo();//obtine todo
                //reccore la lista de ingredientes de nuestro plato seleccionado en cmb o sea si tomas especial solo recorre su lista de ingredientes
                foreach (string nombreIngrediente in platoSeleccionado.Ingredientes) { 
                    //aca se descuenta cantidad al insumo basado en el ingrediente que este o sea se mete a lista ingredientes saca ejemplo: queso
                    //ahora busca en la lista global de productos el insumo con el mismo nombre y si lo encuentra le resta.
                    var insumo = listaInsumosGlobal.Find(i => i.Nombre.Equals(nombreIngrediente, StringComparison.OrdinalIgnoreCase));
                    if (insumo != null) { 
                        insumo.Cantidad -= cantidadPedida;
                    }
                }
                DetalleVenta d = new DetalleVenta()
                {
                    Producto = platoSeleccionado.Nombre,
                    Precio = platoSeleccionado.Precio,
                    Cantidad = cantidadPedida
                };

                detallesActuales.Add(d);

                ActualizarDetalle();
                CalcularTotal();

                txtCantidad.Clear();
            }
            catch
            {
                MessageBox.Show("la cantidad debe ser un numero válido");
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (detallesActuales.Count == 0)
            {
                MessageBox.Show("Agrega productos primero");
                return;
            }

            Venta v = new Venta()
            {
                Fecha = dtpFecha.Value,
                Detalles = new List<DetalleVenta>(detallesActuales)
            };

            listaVentas.Add(v);

            ActualizarVentas();

            detallesActuales.Clear();
            ActualizarDetalle();
            CalcularTotal();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                int index = dgvDetalle.CurrentRow.Index;
                detallesActuales.RemoveAt(index);

                ActualizarDetalle();
                CalcularTotal();
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int index = dgvVentas.CurrentRow.Index;
                listaVentas.RemoveAt(index);

                ActualizarVentas();
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int index = dgvVentas.CurrentRow.Index;

                detallesActuales = new List<DetalleVenta>(listaVentas[index].Detalles);

                ActualizarDetalle();
                CalcularTotal();
                dtpFecha.Value = listaVentas[index].Fecha;
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                int index = dgvDetalle.CurrentRow.Index;

                DetalleVenta detalleSeleccionado = detallesActuales[index];

                EditarDetalle formEditar = new EditarDetalle(detalleSeleccionado);

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarDetalle();
                    CalcularTotal();
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dependiendo de lo que selecciones en cmb se pondra uj precio o otro
            if (cmbProductos.SelectedItem is ProductoFinal seleccionado)
            {
                txtPrecio.Text = seleccionado.Precio.ToString();
            }
        }
    }
}
