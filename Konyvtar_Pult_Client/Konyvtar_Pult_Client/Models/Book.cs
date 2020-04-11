using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Pult_Client.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableQuantity { get; set; }
        public int Quantity { get; set; }
        public List<Patron> patrons { get; set; }
        public double ReplacementCost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int TitleHossz = Title.Length;
            int spacek = 40 - TitleHossz;
            sb.Append(Title);
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(Author);
            return sb.ToString();
        }
        
    }
}
