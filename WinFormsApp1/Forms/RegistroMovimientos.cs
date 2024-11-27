using System.Text;

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
            ActualizarSaldo();
            LlenarDataGriedView(caja.ObtenerMovimientos());
        }

        //Metodo que se usara cada vez que el saldo se mire afectado
        private void ActualizarSaldo ()
        {
        //Unicamente 2 decimales en el saldo
        txtSaldo.Text = $"C$ {caja.Saldo.ToString("F2")}";
        }

        //Metodo para llenar DataGredView con la lista, asi como para asegurar que no esté nada seleccionado
        private void LlenarDataGriedView(IEnumerable<Movimientos> movimientos)
        {
            //limpiar las filas del data
            dgvMovimientos.Rows.Clear();

            //Agregar los movimientos al Data

            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                //Crear una fila con los moviminetos
                dgvMovimientos.Rows.Add(movimiento.Tipo, $"C$ {movimiento.Monto}", movimiento.Concepto, movimiento.Fecha);
            }

            //Se asegura que no se seleccione una fila en el Data al iniciar el form
            dgvMovimientos.CurrentCell = null;
        }

        //Metodo para registrar el movimiento, esto para ligarlo con el MainForm
        public void AgregarMovimiento()
        {
            //Se asegura que no haya un movimiento seleccionado, para evitar una duplicación
            if (dgvMovimientos.CurrentRow != null)
            {
                MessageBox.Show("Acción Invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            dgvMovimientos.Rows.Add(tipo, $"C$ {monto}", concepto, fecha);

            ActualizarSaldo();
            //limpiar campos
            DeseleccionarDatayLimpiarCampos();
        }

        //Metodo para registrar ´modificación de movimiento (será mandado a llamar en el mainform)
        public void EditarMovimientos()
        {
            if (dgvMovimientos.CurrentRow == null || dgvMovimientos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Primero seleccione un movimiento para editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarCampos()) return;

            int filaSeleccionadaIndex = dgvMovimientos.CurrentRow.Index;
            //Creación de movimiento modelo para obtener el movimiento seleccionado para modificación
            var movimientoActual = caja.ObtenerMovimientos()[filaSeleccionadaIndex];

            //Revierte el efecto del movimiento original en caso de modificación
            caja.Revertirmovimiento(movimientoActual);
            // Crea el nuevo movimiento con los datos del formulario
            TipoMovimiento nuevoTipo = (TipoMovimiento)cboMovimientos.SelectedItem;
            double nuevoMonto = Convert.ToDouble(txtMonto.Text);

            //Validación de monto de egreso no sea mayor que el saldo disponible
            if (nuevoTipo == TipoMovimiento.Egreso && Convert.ToDouble(txtMonto.Text) > caja.Saldo)
            {
                MessageBox.Show("El monto del egreso no puede ser mayor al saldo disponible.", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos del movimiento seleccionado
            ActualizarMovimiento(movimientoActual, nuevoTipo, nuevoMonto, txtConceptoDeMovimiento.Text, dateTimePicker1.Value);
            caja.RegistrarMovimientos(movimientoActual);
            // Actualizar la fila en el DataGridView
            ActualizarFila(filaSeleccionadaIndex, movimientoActual);

            // Actualizar saldo en la interfaz
            ActualizarSaldo();
            MessageBox.Show($"Movimiento Modificado:\nTipo: {movimientoActual.Tipo} " + $"\nMonto: {movimientoActual.Monto}" + $"\nConcepto: {movimientoActual.Concepto}" + $"\nFecha: {movimientoActual.Fecha}", "Modificación con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpiar campos
            DeseleccionarDatayLimpiarCampos();
        }

        //Metodo para revertir efecto de movimiento
        private void RevertirEfectoMovimiento(Movimientos movimiento) 
        {
            if (movimiento.Tipo == TipoMovimiento.Ingreso)
            {
                caja.Saldo -= movimiento.Monto; //si el monto se cambia de ingreso a egreso, entonces se revierte el efecto ingreso
            }
            else if (movimiento.Tipo == TipoMovimiento.Egreso)
            {
                caja.Saldo += movimiento.Monto; //Se revierte el efecto de egreso si se cambia de egreso a ingreso
            }
        }

        //Metodo para Actualizar Movimiento por modifcación
        private void ActualizarMovimiento (Movimientos movimiento, TipoMovimiento tipo, double monto, string concepto, DateTime fecha)
        {
            movimiento.Tipo = tipo;
            movimiento.Monto = monto;
            movimiento.Concepto = concepto;
            movimiento.Fecha = fecha;
        }

        private void ActualizarFila (int filaindex, Movimientos movimiento)
        {
            var fila = dgvMovimientos.Rows[filaindex];
            fila.Cells[0].Value = movimiento.Tipo;
            fila.Cells[1].Value = $"C$ {movimiento.Monto:F2}";
            fila.Cells[2].Value = movimiento.Concepto;
            fila.Cells[3].Value = movimiento.Fecha;
        }

        //Metodo para eleiminar movimiento
        public void EliminarMovimiento()
        {
            // Verificar si hay una fila seleccionada
            if (dgvMovimientos.CurrentRow == null || dgvMovimientos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un movimiento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el movimiento seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No) return;

            // Obtener el índice de la fila seleccionada
            int filaSeleccionadaIndex = dgvMovimientos.CurrentRow.Index;

            // Eliminar el movimiento correspondiente de la lista subyacente
            var movimientoAEliminar = caja.ObtenerMovimientos()[filaSeleccionadaIndex];
            caja.Revertirmovimiento(movimientoAEliminar);

            // Eliminar la fila del DataGridView
            dgvMovimientos.Rows.RemoveAt(filaSeleccionadaIndex);

            // Actualizar el saldo en la interfaz
            ActualizarSaldo();
            MessageBox.Show("Movimiento eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario
            DeseleccionarDatayLimpiarCampos();
        }

        //Metodo para guardar movimiento en un txt
        public void GuardarMovimientos()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //Crea un Form y Una barra de Progreso
            var Barradedescarga = new ProgressBar
            {
                Size = new Size(285, 27),
                Style = ProgressBarStyle.Blocks,
                Location = new Point(43, 29),
                MarqueeAnimationSpeed = 10,
                Minimum = 0,
                Maximum = 100,
                Step = 10
            };

            var FormBarraProgreso = new Form
            {
                Size = new Size(389, 128),
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Guardando movimientos",
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
            };

            FormBarraProgreso.Controls.Add(Barradedescarga);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar el formulario antes de iniciar el proceso de guardado
                FormBarraProgreso.Show();

                // Convertir a String la Lista de movimientos
                var movimientos = caja.ObtenerMovimientos();
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Movimientos registrados en caja: ");
                stringBuilder.AppendLine("Tipo\t Monto\t Concepto \t Fecha");

                foreach (var movimiento in movimientos)
                {
                    stringBuilder.AppendLine($"{movimiento.Tipo}\t C$ {movimiento.Monto}\t{movimiento.Concepto}\t{movimiento.Fecha}");
                }

                // Se consume línea de archivo para dar espacio al saldo final
                stringBuilder.AppendLine();
                stringBuilder.AppendLine($"Saldo final de caja: C${caja.Saldo}");

                // Simular progreso mientras se guarda el archivo
                for (int i = Barradedescarga.Minimum; i <= Barradedescarga.Maximum; i += Barradedescarga.Step)
                {
                    Barradedescarga.Value = i; // Incrementar directamente el valor
                    System.Threading.Thread.Sleep(500); // Simula tiempo de procesamiento
                }

                File.WriteAllText(saveFileDialog.FileName, stringBuilder.ToString());

                // Cerrar el formulario de progreso
                FormBarraProgreso.Close();

                // Mostrar mensaje de confirmación
                MessageBox.Show("Movimientos guardados con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo para que cuando se seleccione una fila del data (movimiento) se muestren los datos en los cuadros de texto
        private void SeleccionarMovimiento(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que la fila seleccionada es válida
            if (dgvMovimientos.CurrentRow != null && dgvMovimientos.CurrentRow.Index >= 0)
            {
                // Cargar datos de la fila seleccionada en los controles
                cboMovimientos.SelectedItem = dgvMovimientos.CurrentRow.Cells[0].Value;
                txtMonto.Text = dgvMovimientos.CurrentRow.Cells[1].Value.ToString().Replace("C$", "").Trim();
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

        //Metodo para deseleccionar fila y limpiarcampos 
        private void DeseleccionarDatayLimpiarCampos()
        {
            txtMonto.Clear();
            txtConceptoDeMovimiento.Clear();
            cboMovimientos.SelectedIndex = -1;
            dgvMovimientos.CurrentCell = null;
        }

        //Limpiar campos y deseleccionar movimiento al dar click al Form
        private void Deseleccionarylimpiarcamposalhacerclick(object sender, EventArgs e)
        {
            DeseleccionarDatayLimpiarCampos();
        }

        //Evento para filtrar Movimientos por ingresos
        private void MostrarIngresos(object sender, EventArgs e)
        {
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                if (movimiento.Tipo == TipoMovimiento.Ingreso)
                {
                    dgvMovimientos.Rows.Add(movimiento.Tipo, $"C$ {movimiento.Monto}", movimiento.Concepto, movimiento.Fecha);
                }
            }
        }

        //Evento para mostrar Egresos
        private void MostrarEgresos(object sender, EventArgs e)
        {
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                if (movimiento.Tipo == TipoMovimiento.Egreso)
                {
                    dgvMovimientos.Rows.Add(movimiento.Tipo, $"C$ {movimiento.Monto}", movimiento.Concepto, movimiento.Fecha);
                }
            }
        }

        //Evento para quitar filtros
        private void QuitarFiltros(object sender, EventArgs e)
        {
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                dgvMovimientos.Rows.Add(movimiento.Tipo, $"C$ {movimiento.Monto}", movimiento.Concepto, movimiento.Fecha);
            }
        }

    }
}