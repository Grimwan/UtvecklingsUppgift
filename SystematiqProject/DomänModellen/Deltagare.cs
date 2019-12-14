using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomänModellen
{   //Second object Deltagare. Deltagare stores 3 values an ID, a name and what Tävling the participant is part of.
    public class Deltagare
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public Tävling Tävling { get; set; }
    }
}
