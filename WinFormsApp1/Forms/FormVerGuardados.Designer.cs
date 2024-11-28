namespace WinFormsApp1.Forms
{
    partial class FormVerGuardados
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
            dgvMovimientos = new DataGridView();
            TipodeMovimiento = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtSaldo = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copiarToolStripMenuItem = new ToolStripMenuItem();
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
            dgvMovimientos.Location = new Point(31, 12);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new Size(744, 327);
            dgvMovimientos.TabIndex = 0;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 401);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 15;
            label6.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(72, 398);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 363);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Filtrar:";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(138, 361);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Por ingresos";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += MostrarIngresos;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(256, 361);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Por egresos";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += MostrarEgr;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(369, 361);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "(ninguna)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += QuitarFiltros;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copiarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(180, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += ctm_Copiar;
            // 
            // FormVerGuardados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(txtSaldo);
            Controls.Add(label6);
            Controls.Add(dgvMovimientos);
            Name = "FormVerGuardados";
            Text = "FormVerGuardados";
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
        private Label label6;
        private TextBox txtSaldo;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copiarToolStripMenuItem;
    }
}