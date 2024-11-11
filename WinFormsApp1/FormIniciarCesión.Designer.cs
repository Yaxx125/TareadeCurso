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
            lblTitulo.Location = new Point(45, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(405, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE GESTIÓN DE CAJA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(45, 181);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(405, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(45, 255);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(405, 31);
            txtContraseña.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(45, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(91, 30);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 215);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 4;
            label1.Text = "Contraseña:";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(163, 323);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(161, 46);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += IniciarCesión;
            // 
            // FormIniciarCesión
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(btnIniciar);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
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