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

namespace WinFormsApp1.Forms
{
    public partial class InicializarSaldo : Form
    {
        //lista donde se almacenan los movimientos y que posteriormente se mostraran en el MainForm
        private List<Movimientos> Listademovimientos = new List<Movimientos>();
        //Caja iniciada con saldo 0
        private static Caja caja = new Caja(0);
        public InicializarSaldo()
        {
            InitializeComponent();
        }

        private void Reconocimientodenumeros(object sender, KeyPressEventArgs e)
        {
            //permite que unicamente se ingresen numeros
            //además del ingreso de decimales
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true; //Bloquea si la tecla no es un numero
            }
        }

        private void InicializarCaja(object sender, EventArgs e)
        {
            double saldoInicial = Convert.ToDouble(txtSaldoInicial.Text);
            DateTime fechadeejercicio = dtpFechadeEjercicio.Value;

            Movimientos inicializacióndesaldo = new Ingreso (saldoInicial, "Inicialización de saldo", fechadeejercicio);  
            Listademovimientos.Add(inicializacióndesaldo);
            //Actualización de saldo en la caja
            caja.RegistrarMovimientos(inicializacióndesaldo);
            // Abrir el segundo formulario y pasar el saldo inicial
            RegistroMovimientos registroMovimientosForm = new RegistroMovimientos(saldoInicial);
            MessageBox.Show($"Caja iniciada con exito:\nFecha: {fechadeejercicio} " + $"\nMonton: {saldoInicial}", "Registro con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     }
}
