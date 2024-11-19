namespace WinFormsApp1.Forms
{
    partial class InicializarSaldo
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            dtpFechadeEjercicio = new DateTimePicker();
            label4 = new Label();
            txtSaldoInicial = new TextBox();
            btnInicializar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(9, 8, 9, 8);
            label1.Size = new Size(173, 41);
            label1.TabIndex = 3;
            label1.Text = "Inicializar Saldo";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(9, 8, 9, 8);
            label2.Size = new Size(91, 37);
            label2.TabIndex = 5;
            label2.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(114, 68);
            txtUsuario.Margin = new Padding(2, 0, 2, 0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(151, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "Pulperia Doña Michlet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(9, 8, 9, 8);
            label3.Size = new Size(171, 37);
            label3.TabIndex = 6;
            label3.Text = "Fecha de actividad: ";
            // 
            // dtpFechadeEjercicio
            // 
            dtpFechadeEjercicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechadeEjercicio.Format = DateTimePickerFormat.Short;
            dtpFechadeEjercicio.Location = new Point(195, 104);
            dtpFechadeEjercicio.Name = "dtpFechadeEjercicio";
            dtpFechadeEjercicio.Size = new Size(161, 23);
            dtpFechadeEjercicio.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 134);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(9, 8, 9, 8);
            label4.Size = new Size(258, 37);
            label4.TabIndex = 8;
            label4.Text = "Monto de Inicialización de Caja:";
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSaldoInicial.Location = new Point(284, 142);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(100, 23);
            txtSaldoInicial.TabIndex = 9;
            txtSaldoInicial.KeyPress += Reconocimientodenumeros;
            // 
            // btnInicializar
            // 
            btnInicializar.Anchor = AnchorStyles.Top;
            btnInicializar.Location = new Point(146, 189);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(119, 41);
            btnInicializar.TabIndex = 10;
            btnInicializar.Text = "Iniciar Caja";
            btnInicializar.UseVisualStyleBackColor = true;
            btnInicializar.Click += InicializarCaja;
            // 
            // InicializarSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 262);
            Controls.Add(btnInicializar);
            Controls.Add(txtSaldoInicial);
            Controls.Add(label4);
            Controls.Add(dtpFechadeEjercicio);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Name = "InicializarSaldo";
            Padding = new Padding(10);
            Text = "InicializarSaldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private DateTimePicker dtpFechadeEjercicio;
        private Label label4;
        private TextBox txtSaldoInicial;
        private Button btnInicializar;
    }
}