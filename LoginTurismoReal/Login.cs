using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTurismoReal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = txtUsuario.Text;
                var password = txtPassword.Text;

                if (usuario.Length <= 0 || password.Length <= 0)
                {
                    MessageBox.Show("Los campos no pueden estar vacios");
                }
                else
                {
                    MessageBox.Show("Bienvenido!!");
                    MenuTurismoReal menu = new MenuTurismoReal();
                    menu.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
