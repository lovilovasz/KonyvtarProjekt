using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Pult_Client.Models
{
    public class Patron
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
