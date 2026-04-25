using GestionInventario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionInventario.views
{
    public partial class VentanaAgregarEditar : Form
    {
        private Proveedores provedor = null;
        RepositorioProveedores proveedores = new RepositorioProveedores();

        public VentanaAgregarEditar(Proveedores proveedor = null)
        {
            InitializeComponent();
            this.provedor = proveedor;
            configuracionVentana();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void configuracionVentana()
        {
            if (provedor != null)
            {
                this.Text = "Editar";
                lblTitulo.Text = "Modificar datos";
                btnAccion.Text = "Guardar";

                txtNombre.Text = provedor.Nombre;
                txtTelefono.Text = provedor.Telefono;
                txtCorreo.Text = provedor.Correo;
                txtEmpresa.Text = provedor.Empresa;
                txtDireccion.Text = provedor.Direccion;
            }
            else
            {
                this.Text = "Agregar";
                btnAccion.Text = "Agregar";
                lblTitulo.Text = "Agregar Proveedor.";
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (provedor != null)
            {
                provedor.Nombre = txtNombre.Text;
                provedor.Telefono = txtTelefono.Text;
                provedor.Correo = txtCorreo.Text;
                provedor.Empresa = txtEmpresa.Text;
                provedor.Direccion = txtDireccion.Text;
                MessageBox.Show("Proveedor actualizado con éxito.");
                this.Close();
            }
            else
            {
                Proveedores provedorNuevo = new Proveedores();
                provedorNuevo.Nombre = txtNombre.Text;
                provedorNuevo.Telefono = txtTelefono.Text;
                provedorNuevo.Correo = txtCorreo.Text;
                provedorNuevo.Empresa = txtEmpresa.Text;
                provedorNuevo.Direccion = txtDireccion.Text;
                proveedores.agregar(provedorNuevo);
                MessageBox.Show("Proveedor agregado con éxito.");
            }
            this.Close();
        }
    }
}
