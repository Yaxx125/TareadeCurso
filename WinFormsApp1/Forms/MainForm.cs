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

        //Metodo para mostrar Form en su TabPage correspondientes
        private void MostrarFormenTabPage(Form formulario, TabPage tabPage)
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
            //Crea y muestra form con el objeto caja principal
            if (inicializarSaldo == null)
            {
                inicializarSaldo = new InicializarSaldo(caja);
            }

            MostrarFormenTabPage(inicializarSaldo, tabpInicializar);
        }

        private void Registrar(object sender, EventArgs e)
        {
            //Crea form y se le establece el saldo anteriormente ingresado
            if (registroMovimientos == null)
            {
                registroMovimientos = new RegistroMovimientos(caja);
            }

            //Verifica que se haya iningresado saldo anteriormente, de lo contario no muestra el form
            if (caja.Saldo != 0)
            {
                MostrarFormenTabPage(registroMovimientos, tabpRegistrar);
                tsbAgregar.Visible = true;
                tsbEditar.Visible = true;
                tsbEliminar.Visible = true;
                tsbGuardar.Visible = true;
            }
            else
            {
                MessageBox.Show("Necesita inicializar saldo de caja para acceder", "Inicialice Saldo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void AgregarMovimiento(object sender, EventArgs e)
        {
            if (registroMovimientos != null && !registroMovimientos.IsDisposed)
            {
                // Llama al método AgregarMovimiento en RegistroMovimientos
                registroMovimientos.AgregarMovimiento();
            }
        }

        private void EditarMovimiento(object sender, EventArgs e)
        {
            if (registroMovimientos != null && !registroMovimientos.IsDisposed)
            {
                //Llama al metodo EditarMovimineto en RegistroMovimientos
                registroMovimientos.EditarMovimientos();
            }
        }

        private void GuardarMovimientos(object sender, EventArgs e)
        {
            //Llamada de metodo para Guardar los movimientos
            registroMovimientos.GuardarMovimientos();
        }

        private void EliminarMovimientos(object sender, EventArgs e)
        {
            registroMovimientos.EliminarMovimiento();
        }
    }
}
