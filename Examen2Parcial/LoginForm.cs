using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Activated(object sender, EventArgs e)
        {
            CodigoUsuarioTextBox.Focus();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();
            if (ContrasenaTextBox.Text == "")
            {
                errorProvider1.SetError(ContrasenaTextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();


            Login login = new Login(CodigoUsuarioTextBox.Text, ContrasenaTextBox.Text);

            UsuarioDB usuarioDB = new UsuarioDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticar(login);
            if(usuario != null)
            {
                MenuForm menuFormulario = new MenuForm();
                this.Hide();
                menuFormulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de Usuario Incorrectos");
            }


        }
    }
}
