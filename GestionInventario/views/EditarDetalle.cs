using System;
using System.Windows.Forms;
using GestionInventario.Model;

namespace GestionInventario.views
{
    public partial class EditarDetalle : Form
    {
        public DetalleVenta detalle;

        public EditarDetalle(DetalleVenta d)
        {
            InitializeComponent();
            detalle = d;

            txtProducto.Text = d.Producto;
            txtPrecio.Text = d.Precio.ToString();
            txtCantidad.Text = d.Cantidad.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                detalle.Producto = txtProducto.Text;
                detalle.Precio = double.Parse(txtPrecio.Text);
                detalle.Cantidad = int.Parse(txtCantidad.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Datos inválidos");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e); // reutiliza tu botón guardar
        }
    }
}