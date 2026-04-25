using GestionInventario.Model;
using GestionInventario.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            InicializarDatos();
        }

        private void abrirNuevoPanel(Form ventanaHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                Control controlAnterior = this.panelContenedor.Controls[0];

                this.panelContenedor.Controls.RemoveAt(0);

                if (controlAnterior is Form formularioAnterior)
                {
                    formularioAnterior.Close();
                    formularioAnterior.Dispose();
                }
            }
            ventanaHijo.TopLevel = false;
            ventanaHijo.FormBorderStyle = FormBorderStyle.None; 
            ventanaHijo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(ventanaHijo);
            this.panelContenedor.Tag = ventanaHijo;
            ventanaHijo.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirNuevoPanel(new Prooveedorescs());
        }
        private void InicializarDatos()
        {
            RepositorioProveedores repo = new RepositorioProveedores();

            if (repo.obtenerTodo().Count == 0)
            {
                repo.agregar(new Proveedores(0, "cakito", "+56942819876", "cakoo@gmail.com", "cakorps", "Direccion 1"));
                repo.agregar(new Proveedores(1, "joaquin", "+56942819877", "koku@gmail.com", "Umbrella", "Direccion 2"));
            }
        }
    }
}
