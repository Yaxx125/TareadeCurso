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
            //llamada de metodo para validación de campos
            if (!ValidarCampos()) return;

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
            var movimiento = new Movimientos(tipo, monto, concepto, fecha);
            caja.RegistrarMovimientos(movimiento);
            dgvMovimientos.Rows.Add(tipo, monto, concepto, fecha);

            //Actualizar saldo
            txtSaldo.Text = caja.Saldo.ToString("F2");

            //limpiar campos
            txtMonto.Clear();
            txtConceptoDeMovimiento.Clear();
            cboMovimientos.SelectedIndex = -1;
        }

        //Metodo para registrar ´modificación de movimiento (será mandado a llamar en el mainform)
        public void EditarMovimientos ()
        {
            if (dgvMovimientos.CurrentRow == null || dgvMovimientos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Primero seleccione un movimiento para editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int filaSeleccionadaIndex = dgvMovimientos.CurrentRow.Index;

            if (!ValidarCampos()) return;

            //Creación de nuevo movimiento por modificación
            TipoMovimiento nuevoTipo = (TipoMovimiento)cboMovimientos.SelectedItem;
            var movimientoActual = caja.ObtenerMovimientos()[filaSeleccionadaIndex];

            if (nuevoTipo == TipoMovimiento.Egreso && Convert.ToDouble(txtMonto.Text) > caja.Saldo)
            {
                MessageBox.Show("El monto del egreso no puede ser mayor al saldo disponible.", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos del movimiento seleccionado
            movimientoActual.Tipo = nuevoTipo;
            movimientoActual.Monto = Convert.ToDouble(txtMonto.Text);
            movimientoActual.Concepto = txtConceptoDeMovimiento.Text;
            movimientoActual.Fecha = dateTimePicker1.Value;

            caja.RegistrarMovimientos(movimientoActual);

            // Actualizar la fila en el DataGridView
            var filaSeleccionada = dgvMovimientos.Rows[filaSeleccionadaIndex];
            filaSeleccionada.Cells[0].Value = movimientoActual.Tipo;
            filaSeleccionada.Cells[1].Value = movimientoActual.Monto.ToString("F2");
            filaSeleccionada.Cells[2].Value = movimientoActual.Concepto;
            filaSeleccionada.Cells[3].Value = movimientoActual.Fecha;

            // Actualizar saldo en la interfaz
            txtSaldo.Text = caja.Saldo.ToString("F2");

            //Limpiar campos
            txtMonto.Text = null;
            txtConceptoDeMovimiento.Text = null;
            cboMovimientos.SelectedIndex = -1;
        }

        //Metodo para que cuando se seleccione una fila del data (movimiento) se muestren los datos en los cuadros de texto
        private void SeleccionarMovimiento(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que la fila seleccionada es válida
            if (dgvMovimientos.CurrentRow != null && dgvMovimientos.CurrentRow.Index >= 0)
            {
                // Cargar datos de la fila seleccionada en los controles
                cboMovimientos.SelectedItem = dgvMovimientos.CurrentRow.Cells[0].Value;
                txtMonto.Text = dgvMovimientos.CurrentRow.Cells[1].Value.ToString();
                txtConceptoDeMovimiento.Text = dgvMovimientos.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = (DateTime)dgvMovimientos.CurrentRow.Cells[3].Value;
            }
        }

        // Método de validación de campos
        private bool ValidarCampos()
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(txtConceptoDeMovimiento.Text) || cboMovimientos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de monto
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Por favor, introduzca un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de saldo si es un egreso
            TipoMovimiento tipo = (TipoMovimiento)cboMovimientos.SelectedItem;
            if (tipo == TipoMovimiento.Egreso && monto > caja.Saldo)
            {
                MessageBox.Show("El monto del egreso no puede ser mayor al saldo disponible.", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
