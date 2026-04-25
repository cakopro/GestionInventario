namespace GestionInventario
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelLogin = new Panel();
            labelLogin = new Label();
            pictureLogin = new PictureBox();
            lblUsuario = new Label();
            label2 = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            chbMostrar = new CheckBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(labelLogin);
            resources.ApplyResources(panelLogin, "panelLogin");
            panelLogin.Name = "panelLogin";
            // 
            // labelLogin
            // 
            resources.ApplyResources(labelLogin, "labelLogin");
            labelLogin.ForeColor = SystemColors.ControlLightLight;
            labelLogin.Name = "labelLogin";
            labelLogin.Click += label1_Click;
            // 
            // pictureLogin
            // 
            pictureLogin.Image = Properties.Resources.login;
            resources.ApplyResources(pictureLogin, "pictureLogin");
            pictureLogin.Name = "pictureLogin";
            pictureLogin.TabStop = false;
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Click += label1_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // txtContrasena
            // 
            resources.ApplyResources(txtContrasena, "txtContrasena");
            txtContrasena.Name = "txtContrasena";
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(btnIngresar, "btnIngresar");
            btnIngresar.Name = "btnIngresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            // 
            // chbMostrar
            // 
            resources.ApplyResources(chbMostrar, "chbMostrar");
            chbMostrar.ForeColor = SystemColors.ControlLightLight;
            chbMostrar.Name = "chbMostrar";
            chbMostrar.UseVisualStyleBackColor = true;
            chbMostrar.CheckedChanged += chbMostrar_CheckedChanged;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(chbMostrar);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(lblUsuario);
            Controls.Add(pictureLogin);
            Controls.Add(panelLogin);
            Name = "FormLogin";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogin;
        private Label labelLogin;
        private PictureBox pictureLogin;
        private Label lblUsuario;
        private Label label2;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private CheckBox chbMostrar;
    }
}
