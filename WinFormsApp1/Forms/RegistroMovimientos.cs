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

        //Metodo para mostrar los movimientos y saldo disponible
        private void RegistroMovimientos_Shown(object sender, EventArgs e)
        {
            //Unicamente 2 decimales en el saldo
            txtSaldo.Text = caja.Saldo.ToString("F2");

            //limpiar las filas del data
            dgvMovimientos.Rows.Clear();

            //Agregar los movimientos al Data

            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                //Crear una fila con los moviminetos
                dgvMovimientos.Rows.Add(movimiento.Tipo, movimiento.Monto, movimiento.Concepto, movimiento.Fecha);
            }
        }
    }
}
