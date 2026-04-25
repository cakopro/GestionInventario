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
    public partial class Prooveedorescs : Form
    {
        RepositorioProveedores proveedores = new RepositorioProveedores();

        public Prooveedorescs()
        {
            InitializeComponent();
            rellenarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void rellenarTabla()
        {
            dataProveedores.DataSource = null;
            dataProveedores.DataSource = proveedores.obtenerTodo();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Debe ingresar un id en la busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Text = "";
                return;
            }
            if (!int.TryParse(txtBuscar.Text, out int id) || id < 0)
            {
                MessageBox.Show("Solo puede ingresar un numero entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Text = "";
                return;
            }
            Proveedores provedor = proveedores.obtenerPorId(id);
            if (provedor != null)
            {
                dataProveedores.DataSource = null;
                dataProveedores.DataSource = new List<Proveedores> { provedor };
            }
            else
            {
                MessageBox.Show("El id ingresado no existe.", "Id incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                rellenarTabla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataProveedores.CurrentRow != null)
            {
                int id = (int)dataProveedores.CurrentRow.Cells[0].Value;
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar a este proveedor?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    proveedores.eliminar(id);
                    rellenarTabla();
                    MessageBox.Show("Proveedor eliminado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("Dese seleccionar una fila para eliminar.", "Id incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaAgregarEditar ventana = new VentanaAgregarEditar();
            ventana.ShowDialog();
            rellenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataProveedores.CurrentRow != null)
            {
                int id = (int)dataProveedores.CurrentRow.Cells[0].Value;
                Proveedores provedor = proveedores.obtenerPorId(id);
                VentanaAgregarEditar ventana = new VentanaAgregarEditar(provedor);
                ventana.ShowDialog();
                rellenarTabla();

            }
            else
            {
                MessageBox.Show("Dese seleccionar una fila para actualizar.", "Id incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
