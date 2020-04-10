using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Konyvtar_Server.Models
{
    public class Patron
    {
       public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
