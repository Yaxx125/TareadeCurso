namespace WinFormsApp1.Forms
{
    public partial class InicializarSaldo : Form
    {
        //Caja que será base de ejercicio
        private Caja caja;
        public InicializarSaldo(Caja caja)
        {
            InitializeComponent();
            this.caja = caja;
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
            //validar que el saldo ingresado sea mayor a 0
            if (Convert.ToDouble(txtSaldoInicial.Text) > 0)
            {
                double saldoInicial = Convert.ToDouble(txtSaldoInicial.Text);
                DateTime fechadeejercicio = dtpFechadeEjercicio.Value;

                //Registro de la inicialización de la caja
                Movimientos inicializacióndeSaldo = new Movimientos(TipoMovimiento.Ingreso, saldoInicial, "Inicialización de saldo", fechadeejercicio);


                //Registrar el movimiento en la caja (osea, modificar el saldo)
                caja.RegistrarMovimientos(inicializacióndeSaldo);

                MessageBox.Show($"Caja iniciada con exito:\nFecha: {fechadeejercicio} " + $"\nMonton: {saldoInicial}", "Registro con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingrese un valor mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     }
}
