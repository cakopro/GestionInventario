namespace GestionInventario.views
{
    partial class FormDetalleProducto
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            cmbProveedor = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 37);
            label1.TabIndex = 0;
            label1.Text = "Nuevo/Editar Insumo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 98);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre del insumo:";
            label2.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(317, 98);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 39);
            txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(317, 186);
            txtPrecio.Margin = new Padding(5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 39);
            txtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 190);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(317, 278);
            txtCantidad.Margin = new Padding(5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(201, 39);
            txtCantidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 283);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 520);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Ingreso:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(317, 520);
            dtpFecha.Margin = new Padding(5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(478, 39);
            dtpFecha.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(159, 654);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(466, 654);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 46);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 374);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(228, 32);
            label6.TabIndex = 11;
            label6.Text = "Proveedor asociado:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(317, 374);
            cmbProveedor.Margin = new Padding(5);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(243, 40);
            cmbProveedor.TabIndex = 12;
            // 
            // FormDetalleProducto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 795);
            Controls.Add(cmbProveedor);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "FormDetalleProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDetalleProducto";
            Load += FormDetalleProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label6;
        private ComboBox cmbProveedor;
    }
}