namespace GestionInventario
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnVolver = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            btnProveedores = new Button();
            panelLogo = new Panel();
            panelContenedor = new Panel();
            button2 = new Button();
            panelMenu.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 50, 100);
            panelMenu.Controls.Add(btnVolver);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(308, 1035);
            panelMenu.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Image = Properties.Resources.proveedor;
            btnVolver.ImageAlign = ContentAlignment.TopLeft;
            btnVolver.Location = new Point(24, 511);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(265, 67);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.MiddleLeft;
            btnVolver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.proveedor;
            btnVentas.ImageAlign = ContentAlignment.TopLeft;
            btnVentas.Location = new Point(24, 429);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(265, 67);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.proveedor;
            btnProductos.ImageAlign = ContentAlignment.TopLeft;
            btnProductos.Location = new Point(24, 336);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(265, 67);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = Properties.Resources.proveedor;
            btnProveedores.ImageAlign = ContentAlignment.TopLeft;
            btnProveedores.Location = new Point(24, 226);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(265, 67);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 50, 100);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(308, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1290, 70);
            panelLogo.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(button2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelContenedor.Location = new Point(308, 70);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1290, 965);
            panelContenedor.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(985, 603);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 1035);
            Controls.Add(panelContenedor);
            Controls.Add(panelLogo);
            Controls.Add(panelMenu);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            panelMenu.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelContenedor;
        private Button button1;
        private Button button2;
        private Button btnVolver;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnProveedores;
    }
}