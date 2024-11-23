using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        InicializarSaldo? inicializarSaldo;
        RegistroMovimientos? registroMovimientos;
        //Objeto caja que será compartido entre los forms
        private Caja caja;
        public MainForm()
        {
            InitializeComponent();
            caja = new Caja(0);
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

        private void MostrarFormInicializarSaldoenTabPage(Form formulario, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            tbcControl.SelectedTab = tabPage;
        }

        private void Inicializar(object sender, EventArgs e)
        {
            if (inicializarSaldo == null)
            {
                inicializarSaldo = new InicializarSaldo(caja);
            }

            MostrarFormInicializarSaldoenTabPage(inicializarSaldo, tabpInicializar);
        }

        private void Registrar(object sender, EventArgs e)
        {
            if (registroMovimientos == null)
            {
                registroMovimientos = new RegistroMovimientos(caja);
            }
            MostrarFormInicializarSaldoenTabPage(registroMovimientos, tabpRegistrar);
        }
    }
}
