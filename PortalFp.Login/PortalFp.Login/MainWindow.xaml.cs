using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PortalFp.Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAcceder_Click(object sender, RoutedEventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string contrasena = PwdContraseña.Password.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                TxtMensaje.Text = "Por favor, ingrese usuario y contraseña.";
                TxtMensaje.Foreground = Brushes.Red;
            }

            else if (usuario == "admin" && contrasena == "1234")
            {
                TxtMensaje.Text = "Acceso concedido.";
                TxtMensaje.Foreground = Brushes.Green;

            }
            else
            {
                TxtMensaje.Text = "Usuario o contraseña incorrectos.";
                TxtMensaje.Foreground = Brushes.Red;
            }
        }
    }
}