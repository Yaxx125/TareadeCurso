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
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        InicializarSaldo? inicializarSaldo;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CerrarSesión(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere cerrar sesión?", "Confirmanción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FormIniciarCesión formIniciarCesión = new FormIniciarCesión();
                formIniciarCesión.Show();
                this.Close();
            }
        }

        private void MostrarFormInicializarSaldoenTabPage(Form formulario, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            tbcControl.SelectedTab = tabPage;
        }

        private void Inicializar(object sender, EventArgs e)
        {
            if (inicializarSaldo == null)
            {
                inicializarSaldo = new InicializarSaldo();
            }

            MostrarFormInicializarSaldoenTabPage(inicializarSaldo, tabpInicializar);
        }
    }
}
