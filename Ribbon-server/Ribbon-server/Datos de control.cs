using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

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
        // Ventana de conexion
        public static Conexion Conw = new Conexion();

        // Ventana de opciones
        public static Opciones Opcw = new Opciones();

        // Ventana de login
        public static Principal Priw = new Principal();

        // Ventana main Window
        public static MainWindow Mainw = new MainWindow();
    }

    public class butoncheing : instants
    {
        public static bool WindowActiv = false;

        public static void WindowControl()
        {

            if (WindowActiv == false)
            {
                //show window for first time
                Priw.Show();
                WindowActiv = true;
            }
            else
            {
                //Only change the window visibility
                Priw.Visibility = Visibility.Visible;
            }
        }
    }

    //Boton para ventana de opciones
    public class OpcWindow : butoncheing
    {
        public new static void WindowControl()
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

    //botton para ventana de conexion
    public class ConectWindow : butoncheing
    {
        public new static void WindowControl()
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

