using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Konyvtar_Server.Models
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
    }
}
