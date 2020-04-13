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

namespace WebAPI_Patron_Client
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

        private void SearcForBooks_Click(object sender, RoutedEventArgs e)
        {
            var window = new SearchForBooksWindow();
            window.ShowDialog();

        }

        private void Searchyourloans_Click(object sender, RoutedEventArgs e)
        {
            var window = new SearchForPatrons();
            window.ShowDialog();
        }
    }
}
