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

            ConfigurarCombobox();
        }

        //Metodo que configura combobox
        private void ConfigurarCombobox()
        {
            cboMovimientos.DataSource = Enum.GetValues(typeof(TipoMovimiento));
        }

        private void ReconocimientoDeNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true; //Bloquea si la tecla no es un numero
            }
        }

        //Metodo para mostrar los movimientos y saldo inicializados
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

        //Metodo para registrar el movimiento, esto para ligarlo con el MainForm
        public void AgregarMovimiento()
        {
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(txtConceptoDeMovimiento.Text) || cboMovimientos.Items == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //obtener los datos del formulario
            TipoMovimiento tipo = (TipoMovimiento)cboMovimientos.SelectedItem;
            double monto = Convert.ToDouble(txtMonto.Text);
            string concepto = txtConceptoDeMovimiento.Text;
            DateTime fecha = dateTimePicker1.Value;

            //Verificar que el monto a retirar no sea mayor al saldo disponible
            if (tipo == TipoMovimiento.Egreso && monto > caja.Saldo)
            {
                MessageBox.Show("No se puede retirar un monto mayor al saldo disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Registrar y mostrar movimiento
            var movimiento = new Movimientos(tipo,monto,concepto,fecha);
            caja.RegistrarMovimientos(movimiento);
            dgvMovimientos.Rows.Add(tipo, monto, concepto,fecha);

            //Actualizar saldo
            txtSaldo.Text = caja.Saldo.ToString("F2");

            //limpiar campos
            txtMonto.Clear();
            txtConceptoDeMovimiento.Clear();
            cboMovimientos.SelectedIndex = -1;
        }
    }
}
