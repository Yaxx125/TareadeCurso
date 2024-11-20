using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegistroMovimientos : Form
    {
        private double saldoInicial;
        public RegistroMovimientos(double saldoInicial)
        {
            InitializeComponent();
            this.saldoInicial = saldoInicial;

            this.Shown += RegistroMovimientos_Shown;
        }

        private void RegistroMovimientos_Shown(object sender, EventArgs e)
        {
            txtSaldo.Text = saldoInicial.ToString("F2");
        }

        private void ReconocimientoDeNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true; //Bloquea si la tecla no es un numero
            }
        }

        private void ReconocimientoDeNumeross(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true; //Bloquea si la tecla no es un numero
            }
        }
    }
}
