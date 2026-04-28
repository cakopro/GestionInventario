using GestionInventario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail; 
using System.Text.RegularExpressions;

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
                txtNombre.ForeColor = Color.Black;
                txtTelefono.Text = provedor.Telefono;
                txtTelefono.ForeColor = Color.Black;
                txtCorreo.Text = provedor.Correo;
                txtCorreo.ForeColor = Color.Black;
                txtEmpresa.Text = provedor.Empresa;
                txtEmpresa.ForeColor = Color.Black;
                txtDireccion.Text = provedor.Direccion;
                txtDireccion.ForeColor = Color.Black;
            }
            else
            {
                this.Text = "Agregar";
                btnAccion.Text = "Agregar";
                lblTitulo.Text = "Agregar Proveedor.";
            }
        }

        private bool ValidarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.ForeColor == Color.Gray || String.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Por favor, completa todos los campos.");
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string correo = txtCorreo.Text;
            if (!validarCorreo(correo))
            {
                MessageBox.Show("Formato incorrecto de correo.");
                return;
            }


            if (provedor != null)
            {
                provedor.Nombre = txtNombre.Text;
                provedor.Telefono = txtTelefono.Text.Replace(" ","");
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
                provedorNuevo.Telefono = txtTelefono.Text.Replace(" ","");
                provedorNuevo.Correo = txtCorreo.Text;
                provedorNuevo.Empresa = txtEmpresa.Text;
                provedorNuevo.Direccion = txtDireccion.Text;
                proveedores.agregar(provedorNuevo);
                MessageBox.Show("Proveedor agregado con éxito.");
            }
            this.Close();
        }

        private bool validarCorreo(string email)
        {
            string expresion = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, expresion);
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre proveedor")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre proveedor";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "+56 9 1234 5678")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "+56 9 1234 5678";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo@empresa.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "ejemplo@empresa.com";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "Distribuidora Gastronómica")
            {
                txtEmpresa.Text = "";
                txtEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "")
            {
                txtEmpresa.Text = "Distribuidora Gastronómica";
                txtEmpresa.ForeColor = Color.Gray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Av. Principal 123, Ciudad")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Av. Principal 123, Ciudad";
                txtDireccion.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '+' && txtTelefono.SelectionStart == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
