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
    public partial class MenuTurismoReal : Form
    {
        public MenuTurismoReal()
        {
            InitializeComponent();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Login volver = new Login();
            volver.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ValidarCodigoReserva codigoReserva = new ValidarCodigoReserva();
            codigoReserva.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ValidarCodigoReserva codigoReserva = new ValidarCodigoReserva();
            codigoReserva.Show();
            this.Hide();
        }
    }
}
