using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomänModellen
{
    //First object Tävling. Tävling stores 3 values an ID, a name and list of competitors.
    public class Tävling
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public virtual List<Deltagare> Alladeltagarna { get; set; }
    }
}
