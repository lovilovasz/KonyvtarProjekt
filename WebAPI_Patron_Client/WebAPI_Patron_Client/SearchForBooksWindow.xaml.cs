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
using WebAPI_Patron_Client.DataProviders;
using WebAPI_Patron_Client.Models;

namespace WebAPI_Patron_Client
{
    /// <summary>
    /// Interaction logic for SearchForBooksWindow.xaml
    /// </summary>
    public partial class SearchForBooksWindow : Window
    {
        public IList<Book> booksToShow = new List<Book>();
        private IList<Book> _books;
        private Book _selectedBook;
        public SearchForBooksWindow()
        {
            InitializeComponent();
            IList<Book> konyvek = BookDataProvider.GetBooks();
            BookListBox.ItemsSource = konyvek;
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            booksToShow.Clear();
            UpdateBooks();
        }

        private void UpdateBooks()
        {
            _books = BookDataProvider.GetBooks();
            string Title = TitleTextBox.Text.ToLower();
            string Author = AuthorTextBox.Text.ToLower();
            bool talalt = false;
            bool message1 = false;

            Console.WriteLine(Title + " és " + Author);

            for (int i = 0; i < _books.Count; i++)
            {
                if (Title == "" && Author == "")
                {
                    Console.WriteLine("nincs beirva semmi");
                    MessageBox.Show("Please type in the title or the author to search.", "", MessageBoxButton.OK);
                    message1 = true;
                    break;
                }
                else
                if ((_books[i].Title.ToLower().Contains(Title) && Title != "") || (_books[i].Author.ToLower().Contains(Author) && Author != ""))
                {
                    booksToShow.Add(_books[i]);
                    talalt = true;
                }
            }
            if (talalt == false && message1 == false)
            {
                Console.WriteLine("Nincs találat!");
                MessageBox.Show("No books found", "", MessageBoxButton.OK);
                BookListBox.ItemsSource = "";
                BookListBox.ItemsSource = _books;
            }
            else if (message1 == true)
            {
                BookListBox.ItemsSource = "";
                BookListBox.ItemsSource = _books;
            }
            else
            {
                BookListBox.ItemsSource = "";
                BookListBox.ItemsSource = booksToShow;
            }

        }


    }
}
