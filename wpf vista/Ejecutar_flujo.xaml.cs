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

namespace wpf_vista
{
    /// <summary>
    /// Lógica de interacción para Ejecutar_flujo.xaml
    /// </summary>
    public partial class Ejecutar_flujo : Window
    {
        public Ejecutar_flujo()
        {
            InitializeComponent();
        }

        private void Btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Menu_funcionario mf = new Menu_funcionario();
            mf.Show();
            Close();
        }
    }
}
