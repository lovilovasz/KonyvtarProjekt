using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Patron_Client.Models
{
    public class Patron
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ReturnDate { get; set; }

        public Patron(string name, string cardNumber, DateTime returnDate)
        {
            Name = name;
            CardNumber = cardNumber;
            ReturnDate = returnDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ");
            sb.Append(Name);
            var spacek = 30 - Name.Length;
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(CardNumber);
            spacek = 13 - CardNumber.Length;
            for (int i = 0; i < spacek; i++)
            {
                sb.Append(" ");
            }
            sb.Append(ReturnDate.ToString());
            return sb.ToString();
        }
    }
}
