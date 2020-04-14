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
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearcForBooks_Click(object sender, RoutedEventArgs e)
        {
            var window = new SearchForBooksWindow();
            window.ShowDialog();

        }


        private void SearcForPatrons_Click(object sender, RoutedEventArgs e)
        {
            var window = new SearchForPatrons();
            window.ShowDialog();

        }

        private void AddBooks_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddBookWindow();
            window.ShowDialog();
        }

        private void ExpiredLoans_Click(object sender, RoutedEventArgs e)
        {
            var expired = Expired();
            var window = new ExpiredWindow(expired);
            window.ShowDialog();
        }

        public List<PatronWithTitle> Expired()
        {
            List<PatronWithTitle> patron = new List<PatronWithTitle>();
            IList<Book> book = DataProviders.BookDataProvider.GetBooks();
            for (int i = 0; i < book.Count; i++)
            {
                for (int j = 0; j < book[i].patrons.Count; j++)
                {
                   if (DateTime.Now > book[i].patrons[j].ReturnDate.AddDays(5))
                    {
                        patron.Add(new PatronWithTitle (book[i].patrons[j].Name, book[i].patrons[j].CardNumber, book[i].Title, book[i].patrons[j].ReturnDate));
                    }
                }
            }
            if (patron.Count > 0)
            {
                return patron;
            }
            else
            {
                return null;
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://web.unideb.hu/~lovaszkristof/UserManual/");
        }
    }
}
