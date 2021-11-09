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
using System.IO;

namespace Ribbon_server
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        //Intancias
        Opciones opcioness = new Opciones();
        Conexion conexion = new Conexion();

        public Principal()
        {
            InitializeComponent();
        }

        public void click_xd(object sender, RoutedEventArgs e)
        {
            butoncheing.WindowControl();
            this.Hide();
        }

        private void Opciones_Click(object sender, RoutedEventArgs e)
        {
            if(Datos_de_control.VOpcionesIsActive == false)
            {
                this.Hide();
                opcioness.Show();
                Datos_de_control.VOpcionesIsActive = true;
            }
            else if(Datos_de_control.VOpcionesIsActive == true)
            {
               this.Hide();
               opcioness.Visibility = Visibility.Visible;
            }
         
        }

        private void Conectar_Click(object sender, RoutedEventArgs e)
        {
            if (Datos_de_control.VConexionIsActive == false)
            {
                this.Hide();
                conexion.Show();
                Datos_de_control.VConexionIsActive = true;
            }
            else if(Datos_de_control.VConexionIsActive == true)
            {
                this.Hide();
                conexion.Visibility = Visibility.Visible;
            }
        }
    }
}
