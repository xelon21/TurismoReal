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
    public partial class ValidarCodigoReserva : Form
    {
        public ValidarCodigoReserva()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigoReserva.Text.ToString();

            if(codigo.Length <= 0 || codigo.Length <= 5)
            {
                MessageBox.Show("Codigo invalido");
            }
            else
            {
                MenuTurismoReal menu = new MenuTurismoReal();
                MessageBox.Show("Reserva Ingresada!!");
                menu.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
