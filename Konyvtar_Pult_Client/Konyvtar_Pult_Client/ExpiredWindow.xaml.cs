using Konyvtar_Pult_Client.Models;
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

namespace Konyvtar_Pult_Client
{
    /// <summary>
    /// Interaction logic for ExpiredWindow.xaml
    /// </summary>
    public partial class ExpiredWindow : Window
    {
        public ExpiredWindow(List<PatronWithTitle> patron)
        {
            InitializeComponent();
            ExpiredListBox.ItemsSource = "";
            ExpiredListBox.ItemsSource = patron;
        }

        private void ExpiredListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
