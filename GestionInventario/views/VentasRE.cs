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

        public VentasRE()
        {
            InitializeComponent();
        }

        void ActualizarDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detallesActuales;
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
            if (txtProducto.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            try
            {
                DetalleVenta d = new DetalleVenta()
                {
                    Producto = txtProducto.Text,
                    Precio = double.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCantidad.Text)
                };

                detallesActuales.Add(d);

                ActualizarDetalle();
                CalcularTotal();

                txtProducto.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
            }
            catch
            {
                MessageBox.Show("Ingresa valores numéricos válidos");
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

    }
}
