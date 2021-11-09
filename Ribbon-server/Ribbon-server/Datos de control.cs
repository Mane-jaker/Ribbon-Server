using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ribbon_server
{
    class Datos_de_control
    {

        public static bool Default = true;
        public static bool VOpcionesIsActive = false;
        public static bool VConexionIsActive = false;
    }
    
    public class instants
    {
        public static Conexion Conw = new Conexion();
        public static Opciones Opcw = new Opciones();
        public static MainWindow Maiw = new MainWindow();
    }

    public class butoncheing : instants
    {
        public static bool WindowActiv = false;

        public static void WindowControl()
        {

            if (WindowActiv == false)
            {
                //show window for first time
                Maiw.Show();
                WindowActiv = true;
            }
            else
            {
                //Only change the window visibility
                Maiw.Visibility = Visibility.Visible;
            }
        }
    }

    public class OpcWindow : butoncheing
    {
        public static void WindowControl()
        {

            if (WindowActiv == false)
            {
                //show window for first time
                Opcw.Show();
                WindowActiv = true;
            }
            else
            {
                //Only change the window visibility
                Opcw.Visibility = Visibility.Visible;
            }
        }
    }

    public class ConWindow : butoncheing
    {
        public static void WindowControl()
        {

            if (WindowActiv == false)
            {
                //show window for first time
                Conw.Show();
                WindowActiv = true;
            }
            else
            {
                //Only change the window visibility
                Conw.Visibility = Visibility.Visible;
            }
        }
    }
}

