using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        InicializarSaldo? inicializarSaldo;
        RegistroMovimientos? registroMovimientos;
        FormVerGuardados? verGuardados;
        //Objeto caja que será compartido entre los forms
        private Caja caja;
        public MainForm()
        {
            InitializeComponent();
            caja = new Caja(0);
            this.KeyPreview = true;
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
            else
            {
                return;
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

            MostrarFormenTabPage(registroMovimientos, tabpRegistrar);
            toolStrip1.Visible = true;
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

        private void VerMovmientosGuardados(object sender, EventArgs e)
        {
            if (verGuardados == null)
            {
                verGuardados = new FormVerGuardados(caja);
            }

            verGuardados.CargarMovimientos();
            toolStrip1.Visible = false;
            MostrarFormenTabPage(verGuardados, tabpGuardados);
        }

        private void AtajosdeTeclado(object sender, KeyEventArgs e)
        {
            //Atajos para botones de Panel

            // Verificar si la tecla Alt está presionada
            if (e.Alt)
            {
                // Usar switch para manejar las teclas presionadas con Alt
                switch (e.KeyCode)
                {
                    case Keys.D1:
                        Inicializar(sender, e);
                        break;

                    case Keys.D2:
                        Registrar(sender, e);
                        break;

                    case Keys.D3:
                        VerMovmientosGuardados(sender, e);
                        break;

                    case Keys.D4 :
                        CerrarSesión(sender, e);
                        break;

                    default:
                        break;
                }

                //Atajos Botones de tool strip    
                //Funcionar solamente cuando se muestren en pantalla
                if (toolStrip1.Visible == true)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        AgregarMovimiento(sender, e);
                    }


                    if (e.Control)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.D2:
                                EditarMovimiento(sender, e);
                                break;

                            case Keys.D3:
                                EliminarMovimientos(sender, e);
                                break;

                            case Keys.D4:
                                GuardarMovimientos(sender, e);
                                break;

                            default:
                                break;
                        }
                    }

                }

                if (e.Alt && e.KeyCode == Keys.F4)
                {
                    // Cancelar el cierre la aplicación con alt f4
                    e.SuppressKeyPress = true;
                    CerrarSesión(sender,e);
                }

            }
        }

    }
}
