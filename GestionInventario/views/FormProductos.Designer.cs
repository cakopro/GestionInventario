namespace GestionInventario.views
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnNuevoProducto = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(68, 104);
            dgvProductos.Margin = new Padding(5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1215, 552);
            dgvProductos.TabIndex = 0;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(357, 690);
            btnEditarProducto.Margin = new Padding(5);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(153, 46);
            btnEditarProducto.TabIndex = 12;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(555, 690);
            btnEliminarProducto.Margin = new Padding(5);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(153, 46);
            btnEliminarProducto.TabIndex = 13;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(162, 690);
            btnNuevoProducto.Margin = new Padding(5);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(153, 46);
            btnNuevoProducto.TabIndex = 15;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 16;
            label1.Text = "Insumos";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 894);
            Controls.Add(label1);
            Controls.Add(btnNuevoProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(dgvProductos);
            Margin = new Padding(5);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private Button btnNuevoProducto;
        private Label label1;
    }
}