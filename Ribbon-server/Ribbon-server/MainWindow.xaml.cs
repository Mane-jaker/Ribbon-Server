﻿using System;
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
            //Cerrar ventana si no hay usurarios
            if(Datos_de_control.Default == true)
            {
                this.Hide();
            }
            InitializeComponent();

            //Abrir ventana principal 
            Vprincipal.Show();

        }


    }
}
