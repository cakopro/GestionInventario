using System;
using System.Windows.Forms;
using GestionInventario.Model;

namespace GestionInventario.views
{
    public partial class FormDetalleProducto : Form
    {
        RepositorioProductos repoProductos = new RepositorioProductos();


        RepositorioProveedores repoProveedores = new RepositorioProveedores();


        private Producto productoAEditar = null;


        public FormDetalleProducto(Producto prod = null)
        {
            InitializeComponent();
            productoAEditar = prod;


            CargarProveedores();


            if (productoAEditar != null)
            {
                this.Text = "Editar producto";
                txtNombre.Text = productoAEditar.Nombre;
                txtPrecio.Text = productoAEditar.Precio.ToString();
                txtCantidad.Text = productoAEditar.Cantidad.ToString();
                dtpFecha.Value = productoAEditar.FechaIngreso;
                cmbProveedor.SelectedValue = productoAEditar.ProveedorAsociado;
            }
            else
            {
                this.Text = "Nuevo producto";
            }
        }

        private void CargarProveedores()
        {

            var listaProveedores = repoProveedores.obtenerTodo();


            cmbProveedor.DataSource = listaProveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Nombre";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, llena los campos de nombre y precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (productoAEditar == null)
                {

                    Producto nuevoProducto = new Producto();
                    nuevoProducto.Nombre = txtNombre.Text;
                    nuevoProducto.Precio = double.Parse(txtPrecio.Text);
                    nuevoProducto.Cantidad = int.Parse(txtCantidad.Text);
                    nuevoProducto.FechaIngreso = dtpFecha.Value;

                    if (cmbProveedor.SelectedValue != null)
                    {
                        nuevoProducto.ProveedorAsociado = cmbProveedor.SelectedValue.ToString();
                    }
                    else
                    {
                        nuevoProducto.ProveedorAsociado = "Sin proveedor";
                    }

                    repoProductos.agregar(nuevoProducto);
                    MessageBox.Show("Producto agregado con exito.");
                }
                else
                {

                    productoAEditar.Nombre = txtNombre.Text;
                    productoAEditar.Precio = double.Parse(txtPrecio.Text);
                    productoAEditar.Cantidad = int.Parse(txtCantidad.Text);
                    productoAEditar.FechaIngreso = dtpFecha.Value;

                    if (cmbProveedor.SelectedValue != null)
                    {
                        productoAEditar.ProveedorAsociado = cmbProveedor.SelectedValue.ToString();
                    }
                    else
                    {
                        productoAEditar.ProveedorAsociado = "Sin proveedor";
                    }

                    MessageBox.Show("Producto actualizado con exito.");
                }

                this.Close();
            }
            catch (FormatException)
            {

                MessageBox.Show("Asegurate de ingresar solo numeros validos en precio y cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDetalleProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, llena los campos de nombre y precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (productoAEditar == null)
                {
                    
                    Producto nuevoProducto = new Producto();
                    nuevoProducto.Nombre = txtNombre.Text;
                    nuevoProducto.Precio = double.Parse(txtPrecio.Text);
                    nuevoProducto.Cantidad = int.Parse(txtCantidad.Text);
                    nuevoProducto.FechaIngreso = dtpFecha.Value;

                    if (cmbProveedor.SelectedValue != null)
                    {
                        nuevoProducto.ProveedorAsociado = cmbProveedor.SelectedValue.ToString();
                    }
                    else
                    {
                        nuevoProducto.ProveedorAsociado = "Sin proveedor";
                    }

                    repoProductos.agregar(nuevoProducto);
                    MessageBox.Show("Producto agregado con exito.");
                }
                else
                {
                   
                    productoAEditar.Nombre = txtNombre.Text;
                    productoAEditar.Precio = double.Parse(txtPrecio.Text);
                    productoAEditar.Cantidad = int.Parse(txtCantidad.Text);
                    productoAEditar.FechaIngreso = dtpFecha.Value;

                    if (cmbProveedor.SelectedValue != null)
                    {
                        productoAEditar.ProveedorAsociado = cmbProveedor.SelectedValue.ToString();
                    }
                    else
                    {
                        productoAEditar.ProveedorAsociado = "Sin proveedor";
                    }

                    MessageBox.Show("Producto actualizado con exito.");
                }

                this.Close(); 
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Asegurate de ingresar solo numeros validos en precio y cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}