using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Pult_Client.Models
{
    public class PatronWithTitle
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Title { get; set; }

        public PatronWithTitle(string name, string cardNumber, string title, DateTime returnDate)
        {
            Name = name;
            CardNumber = cardNumber;
            Title = title;
            ReturnDate = returnDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" ").Append(Name);
            int spacek = 15 - Name.Length;
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(CardNumber);
            spacek = 18 - CardNumber.Length;
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(Title);
            spacek = 25 - Title.Length;
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(ReturnDate.ToString());
            return sb.ToString();
        }
    }
}
