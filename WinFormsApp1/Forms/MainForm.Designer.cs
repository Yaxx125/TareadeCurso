namespace WinFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnCerrarSesión = new Button();
            btnRegistrar = new Button();
            btnInicializar = new Button();
            tabInicializar = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            tabInicializar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 468);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnCerrarSesión);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnInicializar);
            groupBox1.Location = new Point(0, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 303);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles de manejo";
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.Anchor = AnchorStyles.None;
            btnCerrarSesión.Location = new Point(52, 198);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(101, 51);
            btnCerrarSesión.TabIndex = 2;
            btnCerrarSesión.Text = "Cerrar Sesión";
            btnCerrarSesión.UseVisualStyleBackColor = true;
            btnCerrarSesión.Click += CerrarSesión;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.Location = new Point(52, 124);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(101, 51);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Movimientos";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnInicializar
            // 
            btnInicializar.Anchor = AnchorStyles.None;
            btnInicializar.Location = new Point(52, 49);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(101, 51);
            btnInicializar.TabIndex = 0;
            btnInicializar.Text = "Inicializar Saldo";
            btnInicializar.UseVisualStyleBackColor = true;
            // 
            // tabInicializar
            // 
            tabInicializar.Controls.Add(tabPage1);
            tabInicializar.Controls.Add(tabPage2);
            tabInicializar.Dock = DockStyle.Fill;
            tabInicializar.Location = new Point(220, 0);
            tabInicializar.Name = "tabInicializar";
            tabInicializar.SelectedIndex = 0;
            tabInicializar.Size = new Size(450, 468);
            tabInicializar.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(442, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inicializar Saldo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(442, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registrar Movimientos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(220, 443);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(450, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(137, 22);
            toolStripButton1.Text = "Agregar Movimiento";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(125, 22);
            toolStripButton2.Text = "Editar Movimiento";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(138, 22);
            toolStripButton3.Text = "Eliminar Movimiento";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(670, 468);
            Controls.Add(toolStrip1);
            Controls.Add(tabInicializar);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de caja";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            tabInicializar.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TabControl tabInicializar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnCerrarSesión;
        private Button btnRegistrar;
        private Button btnInicializar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}