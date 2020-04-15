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
using System.Windows.Shapes;

namespace Konyvtar_Pult_Client
{
    /// <summary>
    /// Interaction logic for SearchForPatrons.xaml
    /// </summary>
    public partial class SearchForPatrons : Window
    {
        private IList<Book> _book;
        public PatronWithTitle _patron;
        public SearchForPatrons()
        {
            InitializeComponent();
            _book = BookDataProvider.GetBooks();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            UpdatePatrons();
        }

        private void BookListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var PatronSelection = PatronListBox.SelectedItem as PatronWithTitle;
            if(PatronSelection != null)
            {
                _patron = PatronSelection;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this patrons debit?","", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                int csereSzam = 0;
                bool talalt = false;
                Book book = new Book();
                for (int i = 0; i < _book.Count; i++)
                {
                    for (int j = 0; j < _book[i].patrons.Count; j++)
                    {
                        if (_book[i].patrons[j].Name.Equals(_patron.Name) && (_book[i].patrons[j].CardNumber.Equals(_patron.CardNumber)) && (_book[i].patrons[j].ReturnDate.Equals(_patron.ReturnDate)))
                        {
                            book = _book[i];
                            csereSzam = j;
                            talalt = true;
                            break;
                        }
                    }

                }
                if (talalt == true)
                {
                    book.patrons.RemoveAt(csereSzam);
                }
                BookDataProvider.UpdateBook(book);
            }
           
        }

        private void UpdatePatrons()
        {
            List<PatronWithTitle> _patron = new List<PatronWithTitle>();
            string name = NameTextBox.Text;
            string number = CardNOTextBox.Text;
            var spf = new CheckName();
            var result = spf.CheckNameTest(name);
            if(result == true)
            {
                Console.WriteLine("Books: " + _book.Count);
                if (name.Equals("") && number.Equals(""))
                {
                    MessageBox.Show("You need to type in the Name and the card number to search!", "", MessageBoxButton.OK);
                }
                else if (!name.Equals("") && !number.Equals(""))
                {
                    //Console.WriteLine("itt vagyok");
                    for (int i = 0; i < _book.Count; i++)
                    {
                        for (int j = 0; j < _book[i].patrons.Count; j++)
                        {
                            Console.WriteLine(name + " " + number);
                            Console.WriteLine(_book[i].patrons[j].Name + " " + _book[i].patrons[j].CardNumber);
                            if ((_book[i].patrons[j].Name.Contains(name)) && (_book[i].patrons[j].CardNumber.Contains(number)))
                            {
                                //Console.WriteLine("itt vagyok2");
                                _patron.Add(new PatronWithTitle(_book[i].patrons[j].Name, _book[i].patrons[j].CardNumber, _book[i].Title, _book[i].patrons[j].ReturnDate));
                            }
                        }
                        Console.WriteLine("------------------");
                    }
                }
                else
                {
                    MessageBox.Show("You need to type in both the Name and card number!", "", MessageBoxButton.OK);
                }
                Console.WriteLine(_patron.Count);
                StringBuilder sb = new StringBuilder();
                PatronListBox.ItemsSource = "";
                PatronListBox.ItemsSource = _patron;
            }
            else
            {
                MessageBox.Show("The name can not contain different characters then letters.", "", MessageBoxButton.OK);
            }
           
        }

    }
}
