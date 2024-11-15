﻿using System;
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
    public partial class MainForm : Form
    {
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
    }
}
