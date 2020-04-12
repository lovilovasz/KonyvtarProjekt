using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Pult_Client.Models
{
    class PatronWithTitle
    {
        string Name { get; set; }
        string CardNumber { get; set; }
        string Title { get; set; }

        public PatronWithTitle(string name, string cardNumber, string title)
        {
            Name = name;
            CardNumber = cardNumber;
            Title = title;
        }
    }
}
