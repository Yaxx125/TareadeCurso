using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class FormVerGuardados : Form
    {
        private Caja caja;
        public FormVerGuardados(Caja caja)
        {
            InitializeComponent();
            this.caja = caja;
        }

        public void CargarMovimientos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] configuracion = File.ReadAllLines(openFileDialog.FileName);
                AplicarMovimientos(configuracion);
                MessageBox.Show("Configuración cargada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AplicarMovimientos(string[] configuración)
        {
            dgvMovimientos.Rows.Clear();
            bool leyendoMovimientos = false;
            foreach (var linea in configuración)
            {
                // Detectar el encabezado y empezar a leer movimientos
                if (linea.StartsWith("Tipo\t"))
                {
                    leyendoMovimientos = true;
                    continue;
                }
                // Procesar líneas de movimientos
                if (leyendoMovimientos && !string.IsNullOrWhiteSpace(linea))
                {
                    var partes = linea.Split('\t'); // Separar por tabulaciones
                    if (partes.Length == 4) // Validar que haya 4 columnas
                    {
                        dgvMovimientos.Rows.Add(partes[0].Trim(), partes[1].Trim(), partes[2].Trim(), partes[3].Trim());
                    }
                }
                // Detectar la línea que contiene el saldo final
                if (linea.StartsWith("Saldo final de caja:"))
                {
                    string saldo = linea.Split(':')[1].Trim().Replace("C$", ""); // Extraer el saldo
                    caja.Saldo = Convert.ToDouble(saldo);
                    txtSaldo.Text = $"C$ {saldo}"; // Mostrarlo en el TextBox
                }
            }
        }

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

        private void MostrarEgr(object sender, EventArgs e)
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

        private void QuitarFiltros(object sender, EventArgs e)
        {
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in caja.ObtenerMovimientos())
            {
                dgvMovimientos.Rows.Add(movimiento.Tipo, $"C$ {movimiento.Monto}", movimiento.Concepto, movimiento.Fecha);
            }
        }

        private void AbrirContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Obtener la posición del ratón en la fila
                var hitTest = dgvMovimientos.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    // Seleccionar la fila donde se hizo clic
                    dgvMovimientos.ClearSelection();
                    dgvMovimientos.Rows[hitTest.RowIndex].Selected = true;

                    // Mostrar el ContextMenuStrip en la posición del cursor
                    contextMenuStrip1.Show(dgvMovimientos, new Point(e.X, e.Y));

                }
            }
        }

        private void ctm_Copiar(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvMovimientos.CurrentRow != null && dgvMovimientos.CurrentRow.Index >= 0)
            {
                var filaSeleccionada = dgvMovimientos.CurrentRow;
                var textoACopiar = "";

                // Recorrer las celdas de la fila seleccionada y obtener los valores
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    textoACopiar += celda.Value.ToString() + "\t"; // Usar tabuladores entre los valores
                }

                // Eliminar el último tabulador
                textoACopiar = textoACopiar.TrimEnd('\t');

                // Copiar al portapapeles
                Clipboard.SetText(textoACopiar);

            }
        }
    

    }
}

