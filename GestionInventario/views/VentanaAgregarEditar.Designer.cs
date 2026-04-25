namespace GestionInventario.views
{
    partial class VentanaAgregarEditar
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
            panelTitulo = new Panel();
            lblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAccion = new Button();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtEmpresa = new TextBox();
            txtDireccion = new TextBox();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(30, 50, 100);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(589, 114);
            panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(56, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(486, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 163);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 252);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 351);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 447);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 4;
            label5.Text = "Empresa:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(56, 552);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(51, 679);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(479, 49);
            btnAccion.TabIndex = 6;
            btnAccion.Text = "button1";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 198);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(479, 39);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(51, 287);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(479, 39);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(51, 386);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(479, 39);
            txtCorreo.TabIndex = 9;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(51, 482);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(479, 39);
            txtEmpresa.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(56, 587);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(479, 39);
            txtDireccion.TabIndex = 11;
            // 
            // VentanaAgregarEditar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 30, 60);
            ClientSize = new Size(589, 825);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmpresa);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(btnAccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelTitulo);
            Name = "VentanaAgregarEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaAgregarEditar";
            panelTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAccion;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtEmpresa;
        private TextBox txtDireccion;
    }
}