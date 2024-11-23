using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class RegistroMovimientos : Form
    {
        private Caja caja;
        public RegistroMovimientos(Caja caja)
        {
            InitializeComponent();
            this.caja = caja;

            this.Shown += RegistroMovimientos_Shown;
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

        //Metodo para mostrar el saldo ingresado
        private void RegistroMovimientos_Shown(object sender, EventArgs e)
        {
            txtSaldo.Text = caja.Saldo.ToString("F2");
        }
    }
}
