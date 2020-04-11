using Konyvtar_Pult_Client.DataProviders;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Konyvtar_Pult_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<Book> _books;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearcForBooks_Click(object sender, RoutedEventArgs e)
        {


        }


        private void SearcForPatrons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBooks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateBooks()
        {
            var book = BookDataProvider.GetBooks();

        }
    }
}
