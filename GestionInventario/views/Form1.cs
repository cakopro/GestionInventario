using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionInventario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
//holaaa??
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debe ingresar ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            string usuarioCorrecto = "cako";
            string contrasenaCorrecta = "123";

            if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
            {
                Principal ventana = new Principal();
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chbMostrar.Checked;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
