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

namespace ScuolaVerifica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void crea_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno();
            a.nome = nome.Text;
            a.cognome = Cognome.Text;
            string s = eta.Text;

            a.eta = eta.Text;

        }
    }
}
