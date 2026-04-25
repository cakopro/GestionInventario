namespace GestionInventario.views
{
    partial class VentasRE
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
            label3 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnAgregarProducto = new Button();
            groupBox1 = new GroupBox();
            dgvDetalle = new DataGridView();
            btnEliminarProducto = new Button();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            btnEditarProducto = new Button();
            btnGuardarVenta = new Button();
            groupBox2 = new GroupBox();
            dgvVentas = new DataGridView();
            label5 = new Label();
            lblTotal = new Label();
            btnEliminarVenta = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 27);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 31);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(90, 20);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(322, 24);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(569, 24);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(727, 24);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDetalle);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 184);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de venta";
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(0, 26);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(959, 158);
            dgvDetalle.TabIndex = 0;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(12, 283);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(94, 29);
            btnEliminarProducto.TabIndex = 8;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 350);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(66, 343);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(291, 27);
            dtpFecha.TabIndex = 10;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(877, 283);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(94, 29);
            btnEditarProducto.TabIndex = 11;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(877, 386);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(94, 29);
            btnGuardarVenta.TabIndex = 12;
            btnGuardarVenta.Text = "Guardar";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvVentas);
            groupBox2.Location = new Point(12, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(959, 172);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial de ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(0, 26);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(959, 146);
            dgvVentas.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 350);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(564, 350);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 20);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "$0";
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(12, 590);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(94, 29);
            btnEliminarVenta.TabIndex = 16;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // VentasRE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 690);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnGuardarVenta);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(btnEditarProducto);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(btnEliminarProducto);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentasRE";
            Text = "Sistema de ventas";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnAgregarProducto;
        private GroupBox groupBox1;
        private DataGridView dgvDetalle;
        private Button btnEliminarProducto;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Button btnEditarProducto;
        private Button btnGuardarVenta;
        private GroupBox groupBox2;
        private DataGridView dgvVentas;
        private Label label5;
        private Label lblTotal;
        private Button btnEliminarVenta;
    }
}