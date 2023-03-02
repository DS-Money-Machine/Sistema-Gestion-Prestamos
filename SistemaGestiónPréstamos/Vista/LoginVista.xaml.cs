using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaGestiónPréstamos.Vista
{
  
    public partial class LoginVista : Window
    {
        public LoginVista()
        {
            InitializeComponent();
        }

        // - Mover la ventana - //
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // - Botones Mininimzar y Cerrar - //
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // - Textbox Usuario y contraseña - //
        private void textUsuario_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && txtUsuario.Text.Length > 0)
                textUsuario.Visibility = Visibility.Collapsed;
            else
                textUsuario.Visibility = Visibility.Visible;
        }

        private void textContraseña_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtContraseña.Focus();
        }

        private void txtContraseña_ContraseñaChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContraseña.Password) && txtContraseña.Password.Length > 0)
                textContraseña.Visibility = Visibility.Collapsed;
            else
                textContraseña.Visibility = Visibility.Visible;
        }

        // - Boton Inicia Sesión - //
        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Crear una instancia de la ventana InterfazPrincipal
            VistaPrincipal ventanaInterfaz = new VistaPrincipal();

            // Mostrar la ventana InterfazPrincipal
            ventanaInterfaz.Show();

            // Cerrar la ventana Login
            this.Close();
        }

    }
}
