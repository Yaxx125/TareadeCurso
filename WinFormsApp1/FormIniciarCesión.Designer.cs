namespace WinFormsApp1
{
    partial class FormIniciarCesión
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
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblUsuario = new Label();
            label1 = new Label();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(32, 35);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(278, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE GESTIÓN DE CAJA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(32, 112);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(285, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(32, 173);
            txtContraseña.Margin = new Padding(2, 2, 2, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(285, 23);
            txtContraseña.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(32, 85);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 142);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Contraseña:";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(114, 210);
            btnIniciar.Margin = new Padding(2, 2, 2, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(113, 28);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += IniciarCesión;
            // 
            // FormIniciarCesión
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 270);
            Controls.Add(btnIniciar);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormIniciarCesión";
            Text = "FormIniciarCesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblUsuario;
        private Label label1;
        private Button btnIniciar;
    }
}