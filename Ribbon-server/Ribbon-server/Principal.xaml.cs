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

            Grid migrid = new Grid();

            this.Content = migrid;

            Button xd = new Button();

            WrapPanel jiji = new WrapPanel();

            TextBlock oyea = new TextBlock();

            oyea.Text = "fokiu samababich";

            jiji.Children.Add(oyea);

            xd.Content = jiji; 

            migrid.Children.Add(xd);
        }

  
    }
}
