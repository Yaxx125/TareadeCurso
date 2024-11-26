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
            tbcControl = new TabControl();
            tabpInicializar = new TabPage();
            tabpRegistrar = new TabPage();
            toolStrip1 = new ToolStrip();
            tsbImportar = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            tbcControl.SuspendLayout();
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
            panel1.Size = new Size(220, 580);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnCerrarSesión);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnInicializar);
            groupBox1.Location = new Point(3, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 277);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles de manejo";
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesión.Location = new Point(52, 207);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(101, 51);
            btnCerrarSesión.TabIndex = 2;
            btnCerrarSesión.Text = "Cerrar Sesión";
            btnCerrarSesión.UseVisualStyleBackColor = true;
            btnCerrarSesión.Click += CerrarSesión;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Left;
            btnRegistrar.Location = new Point(52, 130);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(101, 51);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Movimientos";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += Registrar;
            // 
            // btnInicializar
            // 
            btnInicializar.Location = new Point(52, 53);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(101, 51);
            btnInicializar.TabIndex = 0;
            btnInicializar.Text = "Inicializar Saldo";
            btnInicializar.UseVisualStyleBackColor = true;
            btnInicializar.Click += Inicializar;
            // 
            // tbcControl
            // 
            tbcControl.Controls.Add(tabpInicializar);
            tbcControl.Controls.Add(tabpRegistrar);
            tbcControl.Dock = DockStyle.Fill;
            tbcControl.Location = new Point(220, 0);
            tbcControl.Name = "tbcControl";
            tbcControl.SelectedIndex = 0;
            tbcControl.Size = new Size(740, 580);
            tbcControl.TabIndex = 1;
            // 
            // tabpInicializar
            // 
            tabpInicializar.Location = new Point(4, 24);
            tabpInicializar.Name = "tabpInicializar";
            tabpInicializar.Padding = new Padding(3);
            tabpInicializar.Size = new Size(732, 552);
            tabpInicializar.TabIndex = 0;
            tabpInicializar.Text = "Inicializar Saldo";
            tabpInicializar.UseVisualStyleBackColor = true;
            // 
            // tabpRegistrar
            // 
            tabpRegistrar.Location = new Point(4, 24);
            tabpRegistrar.Name = "tabpRegistrar";
            tabpRegistrar.Padding = new Padding(3);
            tabpRegistrar.Size = new Size(732, 552);
            tabpRegistrar.TabIndex = 1;
            tabpRegistrar.Text = "Registrar Movimientos";
            tabpRegistrar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbImportar, tsbGuardar, tsbAgregar, tsbEditar, tsbEliminar });
            toolStrip1.Location = new Point(220, 555);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(740, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbImportar
            // 
            tsbImportar.Image = (Image)resources.GetObject("tsbImportar.Image");
            tsbImportar.ImageTransparentColor = Color.Magenta;
            tsbImportar.Name = "tsbImportar";
            tsbImportar.Size = new Size(146, 22);
            tsbImportar.Text = "Importar Movimientos";
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(142, 22);
            tsbGuardar.Text = "Guardar Movimientos";
            tsbGuardar.Visible = false;
            tsbGuardar.Click += GuardarMovimientos;
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(137, 22);
            tsbAgregar.Text = "Agregar Movimiento";
            tsbAgregar.Visible = false;
            tsbAgregar.Click += AgregarMovimiento;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(125, 22);
            tsbEditar.Text = "Editar Movimiento";
            tsbEditar.Visible = false;
            tsbEditar.Click += EditarMovimiento;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(138, 22);
            tsbEliminar.Text = "Eliminar Movimiento";
            tsbEliminar.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(960, 580);
            Controls.Add(toolStrip1);
            Controls.Add(tbcControl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de caja";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            tbcControl.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TabControl tbcControl;
        private TabPage tabpInicializar;
        private TabPage tabpRegistrar;
        private Button btnCerrarSesión;
        private Button btnRegistrar;
        private Button btnInicializar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbImportar;
    }
}