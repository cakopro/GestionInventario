namespace GestionInventario.views
{
    partial class Prooveedorescs
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
            dataProveedores = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            empresa = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProveedores).BeginInit();
            SuspendLayout();
            // 
            // dataProveedores
            // 
            dataProveedores.AllowUserToDeleteRows = false;
            dataProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProveedores.Columns.AddRange(new DataGridViewColumn[] { Id, nombre, telefono, correo, empresa, direccion });
            dataProveedores.Location = new Point(31, 233);
            dataProveedores.Name = "dataProveedores";
            dataProveedores.ReadOnly = true;
            dataProveedores.RowHeadersWidth = 82;
            dataProveedores.Size = new Size(1087, 596);
            dataProveedores.TabIndex = 0;
            dataProveedores.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Identificador";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 10;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Resizable = DataGridViewTriState.False;
            nombre.Width = 167;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Tefefono";
            telefono.MinimumWidth = 10;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Resizable = DataGridViewTriState.False;
            telefono.Width = 168;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 10;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Resizable = DataGridViewTriState.False;
            correo.Width = 167;
            // 
            // empresa
            // 
            empresa.DataPropertyName = "empresa";
            empresa.HeaderText = "Empresa";
            empresa.MinimumWidth = 10;
            empresa.Name = "empresa";
            empresa.ReadOnly = true;
            empresa.Resizable = DataGridViewTriState.False;
            empresa.Width = 167;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 10;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Resizable = DataGridViewTriState.False;
            direccion.Width = 167;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(193, 36);
            label1.TabIndex = 1;
            label1.Text = "Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 170);
            label2.Name = "label2";
            label2.Size = new Size(275, 36);
            label2.TabIndex = 2;
            label2.Text = "Buscar proveedor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(303, 171);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(641, 39);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(978, 166);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 49);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1131, 318);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1131, 386);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 6;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1131, 451);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 7;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Prooveedorescs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1293, 894);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataProveedores);
            Name = "Prooveedorescs";
            Text = "Prooveedorescs";
            ((System.ComponentModel.ISupportInitialize)dataProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataProveedores;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn empresa;
        private DataGridViewTextBoxColumn direccion;
    }
}