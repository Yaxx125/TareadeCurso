namespace WinFormsApp1
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
            dataGridView1 = new DataGridView();
            TipodeMovimiento = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TipodeMovimiento, Monto, Concepto, Fecha });
            dataGridView1.Location = new Point(57, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(601, 186);
            dataGridView1.TabIndex = 0;
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
            // RegistroMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 553);
            Controls.Add(dataGridView1);
            Name = "RegistroMovimientos";
            Padding = new Padding(10);
            Text = "RegistroMovimientos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TipodeMovimiento;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Fecha;
    }
}