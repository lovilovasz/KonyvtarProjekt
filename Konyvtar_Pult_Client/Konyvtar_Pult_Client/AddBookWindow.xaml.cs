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
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            if(TitleTextBox.Text.Equals("") || QuantityTextBox.Text.Equals("") || ReplacementCostTextBox.Text.Equals(""))
            {
                MessageBox.Show("Marked with '*'.", "Fill in the necessary boxes!", MessageBoxButton.OK);
            }
            else
            {
                List<Patron> _patron = new List<Patron>();
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                if (AQTextBox.Text.Equals(""))
                {
                    book.AvailableQuantity = int.Parse(QuantityTextBox.Text);
                }
                else
                {
                    book.AvailableQuantity = int.Parse(AQTextBox.Text);
                }
                book.Quantity = int.Parse(QuantityTextBox.Text);
                book.ReplacementCost = int.Parse(ReplacementCostTextBox.Text);
                book.patrons = _patron;
                BookDataProvider.CreateBook(book);
                TitleTextBox.Text = "";
                AuthorTextBox.Text = "";
                AQTextBox.Text = "";
                QuantityTextBox.Text = "";
                ReplacementCostTextBox.Text = "";
            }
            
           
        }
    }
}
