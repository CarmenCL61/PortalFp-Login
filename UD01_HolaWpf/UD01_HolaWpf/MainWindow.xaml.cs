using System.Windows;
using System.Windows.Media;

namespace UD01_HolaWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                TxtMensaje.Text = "Por favor, escribe tu nombre.";
                TxtMensaje.Foreground = Brushes.Red;
            }
            else
            {
                TxtMensaje.Text = $"¡Hola, {nombre}! Bienvenido a WPF con .NET.";
                TxtMensaje.Foreground = Brushes.DeepSkyBlue; // Color válido de WPF
            }
        }
    }
}
