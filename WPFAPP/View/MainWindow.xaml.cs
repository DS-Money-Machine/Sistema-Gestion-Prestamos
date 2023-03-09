using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAPP.ViewModels;

namespace WPFAPP.View
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }
        

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        // - Eventos de barra de control


        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }
       

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == false)
            {
                tt_Inicio.Visibility = Visibility.Collapsed;
                tt_Préstamos.Visibility = Visibility.Collapsed;
                tt_Cobranzas.Visibility = Visibility.Collapsed;
                tt_Manten.Visibility = Visibility.Collapsed;
                tt_Seguridad.Visibility = Visibility.Collapsed;
                tt_Reportes.Visibility = Visibility.Collapsed;
                tt_Config.Visibility = Visibility.Collapsed;


            }
            else
            {
                tt_Inicio.Visibility = Visibility.Visible;
                tt_Préstamos.Visibility = Visibility.Visible;
                tt_Cobranzas.Visibility = Visibility.Visible;
                tt_Manten.Visibility = Visibility.Visible;
                tt_Seguridad.Visibility = Visibility.Visible;
                tt_Reportes.Visibility = Visibility.Visible;
                tt_Config.Visibility = Visibility.Visible;


            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void MenuViewItems_MouseClick(object sender, RoutedEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                mnItem_Préstamos.Visibility = Visibility.Collapsed;
                mnItem_Préstamos2.Visibility = Visibility.Collapsed;
                


            }
            else
            {
                mnItem_Préstamos.Visibility = Visibility.Visible;
                mnItem_Préstamos2.Visibility = Visibility.Visible;
                

            }
        }
    }
}


