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
    public partial class FormIniciarCesión : Form
    {
        public FormIniciarCesión()
        {
            InitializeComponent();
        }

        private void IniciarCesión(object sender, EventArgs e)
        {
            string username = "Pulperia Doña Michlet";
            string contraseña = "Pulperia2024";

            string usuarioingresado = txtUsuario.Text;
            string contraseñaingresada = txtContraseña.Text;

            if (username == usuarioingresado && contraseña == contraseñaingresada)
            {
                var MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o nombre de usuario incorrectos", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
