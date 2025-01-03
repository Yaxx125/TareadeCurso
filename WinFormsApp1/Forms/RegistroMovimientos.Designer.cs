﻿namespace WinFormsApp1
{
    partial class RegistroMovimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMovimientos));
            dgvMovimientos = new DataGridView();
            TipodeMovimiento = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdbIngresos = new RadioButton();
            rdbEgresos = new RadioButton();
            cboMovimientos = new ComboBox();
            txtMonto = new TextBox();
            txtConceptoDeMovimiento = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtSaldo = new TextBox();
            rbdNinguno = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarMovimientoToolStripMenuItem = new ToolStripMenuItem();
            copiarMovimientoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AllowUserToResizeColumns = false;
            dgvMovimientos.AllowUserToResizeRows = false;
            dgvMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { TipodeMovimiento, Monto, Concepto, Fecha });
            dgvMovimientos.Location = new Point(57, 26);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new Size(601, 186);
            dgvMovimientos.TabIndex = 0;
            dgvMovimientos.CellClick += SeleccionarMovimiento;
            dgvMovimientos.MouseDown += AbrirContextMenu;
            // 
            // TipodeMovimiento
            // 
            TipodeMovimiento.HeaderText = "Tipo de Movimiento";
            TipodeMovimiento.Name = "TipodeMovimiento";
            TipodeMovimiento.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 258);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 299);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de movimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 344);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 381);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 4;
            label4.Text = "Concepto de movimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 423);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha";
            // 
            // rdbIngresos
            // 
            rdbIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbIngresos.AutoSize = true;
            rdbIngresos.Location = new Point(164, 256);
            rdbIngresos.Name = "rdbIngresos";
            rdbIngresos.Size = new Size(90, 19);
            rdbIngresos.TabIndex = 7;
            rdbIngresos.TabStop = true;
            rdbIngresos.Text = "Por ingresos";
            rdbIngresos.UseVisualStyleBackColor = true;
            rdbIngresos.Click += MostrarIngresos;
            // 
            // rdbEgresos
            // 
            rdbEgresos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbEgresos.AutoSize = true;
            rdbEgresos.Location = new Point(282, 256);
            rdbEgresos.Name = "rdbEgresos";
            rdbEgresos.Size = new Size(86, 19);
            rdbEgresos.TabIndex = 8;
            rdbEgresos.TabStop = true;
            rdbEgresos.Text = "Por egresos";
            rdbEgresos.UseVisualStyleBackColor = true;
            rdbEgresos.Click += MostrarEgresos;
            // 
            // cboMovimientos
            // 
            cboMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboMovimientos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovimientos.FormattingEnabled = true;
            cboMovimientos.Location = new Point(186, 299);
            cboMovimientos.Name = "cboMovimientos";
            cboMovimientos.Size = new Size(121, 23);
            cboMovimientos.TabIndex = 9;
            // 
            // txtMonto
            // 
            txtMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMonto.Location = new Point(131, 336);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 23);
            txtMonto.TabIndex = 10;
            txtMonto.KeyPress += ReconocimientoDeNumeros;
            // 
            // txtConceptoDeMovimiento
            // 
            txtConceptoDeMovimiento.Location = new Point(213, 373);
            txtConceptoDeMovimiento.Name = "txtConceptoDeMovimiento";
            txtConceptoDeMovimiento.Size = new Size(122, 23);
            txtConceptoDeMovimiento.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 423);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 428);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(558, 420);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 15;
            // 
            // rbdNinguno
            // 
            rbdNinguno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbdNinguno.AutoSize = true;
            rbdNinguno.Location = new Point(395, 256);
            rbdNinguno.Name = "rbdNinguno";
            rbdNinguno.Size = new Size(77, 19);
            rbdNinguno.TabIndex = 16;
            rbdNinguno.TabStop = true;
            rbdNinguno.Text = "(ninguna)";
            rbdNinguno.UseVisualStyleBackColor = true;
            rbdNinguno.Click += QuitarFiltros;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarMovimientoToolStripMenuItem, copiarMovimientoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 48);
            // 
            // eliminarMovimientoToolStripMenuItem
            // 
            eliminarMovimientoToolStripMenuItem.Image = (Image)resources.GetObject("eliminarMovimientoToolStripMenuItem.Image");
            eliminarMovimientoToolStripMenuItem.Name = "eliminarMovimientoToolStripMenuItem";
            eliminarMovimientoToolStripMenuItem.Size = new Size(185, 22);
            eliminarMovimientoToolStripMenuItem.Text = "Eliminar Movimiento";
            eliminarMovimientoToolStripMenuItem.Click += cms_Eliminar;
            // 
            // copiarMovimientoToolStripMenuItem
            // 
            copiarMovimientoToolStripMenuItem.Name = "copiarMovimientoToolStripMenuItem";
            copiarMovimientoToolStripMenuItem.Size = new Size(185, 22);
            copiarMovimientoToolStripMenuItem.Text = "Copiar Movimiento";
            copiarMovimientoToolStripMenuItem.Click += cms_Copiar;
            // 
            // RegistroMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 603);
            Controls.Add(rbdNinguno);
            Controls.Add(txtSaldo);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtConceptoDeMovimiento);
            Controls.Add(txtMonto);
            Controls.Add(cboMovimientos);
            Controls.Add(rdbEgresos);
            Controls.Add(rdbIngresos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMovimientos);
            Name = "RegistroMovimientos";
            Padding = new Padding(10);
            Text = "RegistroMovimientos";
            Click += Deseleccionarylimpiarcamposalhacerclick;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovimientos;
        private DataGridViewTextBoxColumn TipodeMovimiento;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Fecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rdbIngresos;
        private RadioButton rdbEgresos;
        private ComboBox cboMovimientos;
        private TextBox txtMonto;
        private TextBox txtConceptoDeMovimiento;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtSaldo;
        private RadioButton rbdNinguno;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarMovimientoToolStripMenuItem;
        private ToolStripMenuItem copiarMovimientoToolStripMenuItem;
    }
}