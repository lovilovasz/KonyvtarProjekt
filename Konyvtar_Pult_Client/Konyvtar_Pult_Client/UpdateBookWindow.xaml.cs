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
    /// Interaction logic for UpdateBookWindow.xaml
    /// </summary>
    public partial class UpdateBookWindow : Window
    {
        private Book selectedBook;
        public UpdateBookWindow(Book _book)
        {
            InitializeComponent();
            selectedBook = _book;
            TitleTextBox.Text = _book.Title;
            AuthorTextBox.Text = _book.Author;
            AQTextBox.Text = (_book.Quantity - _book.patrons.Count).ToString();
            QuantityTextBox.Text = _book.Quantity.ToString();
            ReplacementCostTextBox.Text = _book.ReplacementCost.ToString() + " $";
            PatronListBox.ItemsSource = _book.patrons;
            DateTime TimeNow = DateTime.Now;
            TimeNow = TimeNow.AddDays(20);
            ReturnDateTextBox.Text = TimeNow.ToString();
        }

        private void UpdateBook_Click(object sender, RoutedEventArgs e)
        {
            selectedBook.Title = TitleTextBox.Text;
            selectedBook.Author = AuthorTextBox.Text;
            selectedBook.Quantity = int.Parse(QuantityTextBox.Text);
            selectedBook.ReplacementCost = int.Parse(ReplacementCostTextBox.Text.Replace(" $", ""));
            selectedBook.AvailableQuantity = int.Parse(QuantityTextBox.Text) - selectedBook.patrons.Count;
            
            if((NameTextBox.Text == "" || CardnoTextBox.Text == "")){
                Console.WriteLine("Nem lett kiadva senkinek!");
            }else if (selectedBook.AvailableQuantity == 0)
            {
                MessageBox.Show("There is no books left to give out!", "", MessageBoxButton.OK);
            }
            else if ((NameTextBox.Text != "" && CardnoTextBox.Text != "" && ReturnDateTextBox.Text != ""))
            {
                var _patron = new Patron(NameTextBox.Text, CardnoTextBox.Text, DateTime.Parse(ReturnDateTextBox.Text));
                selectedBook.patrons.Add(_patron);
            }
            else
            {
                MessageBox.Show("You did not type in the Name of the patron or his/her card number");
                Console.WriteLine("nem irta be a nevet vagy a kartya szamot");
            }
            BookDataProvider.UpdateBook(selectedBook);
            Close();
        }
    }
}
