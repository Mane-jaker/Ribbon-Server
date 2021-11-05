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
using Renci.SshNet;

namespace Ribbon_server
{
    /// <summary>
    /// Lógica de interacción para Conexion.xaml
    /// </summary>
    /// 
    public partial class Conexion : Window
    {

        

        public Conexion()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            Principal Vprincipal = new Principal();
            Vprincipal.Visibility = Visibility.Visible;
            this.Hide();
        }

        private void Conexion1_Click(object sender, RoutedEventArgs e)
        {
            
     

            var connectionInfo = new PasswordConnectionInfo("192.168.1.20", "rb-server", "ribbonserver");
            
            using (var client = new SshClient(connectionInfo))
            {
                
                client.Connect();
               

            }
        }
    }
}
