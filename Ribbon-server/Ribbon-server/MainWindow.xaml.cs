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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Ribbon_server
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         Principal Vprincipal = new Principal();
        public MainWindow()
        {
       
            InitializeComponent();
            //Abrir ventana principal 
       

        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            butoncheing.WindowControl();
            this.Hide();
        }

        private void Opciones_Click(object sender, RoutedEventArgs e)
        {
            OpcWindow.WindowControl();
            this.Hide();
        }

        private void Conectar_Click(object sender, RoutedEventArgs e)
        {
            ConectWindow.WindowControl();
            this.Hide();
        }


    }
}
