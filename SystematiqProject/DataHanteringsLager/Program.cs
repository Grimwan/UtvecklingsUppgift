using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomänModellen;
namespace DataHanteringsLager
{
    class Program
    {
        static void Main(string[] args)
        {



            /*Deltagare deltagare = new Deltagare()
            {
                Namn = "Merry Kulenovic"
            };
            Tävling tävling = new Tävling()
            {
                Namn = "yugioh",
                ID = 2
            };


            context.Tävling.Add(tävling);
            context.SaveChanges();*/
            QueryStringArray();
        }
        static void QueryStringArray()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            var blah = context.Deltagare;
            var list = from Name in blah select Name;
            Console.WriteLine("Yo");
        }

    }
}
