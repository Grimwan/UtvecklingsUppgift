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

            DataHanteringsLager test = new DataHanteringsLager();
            var blahh = test.GetAllTävlingar();
            var blahhh = test.GetTävling(1);

            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();

            List<Deltagare> alladeltagarna = context.Deltagare.ToList<Deltagare>();
            Tävling tävling = new Tävling()
            {
                Namn = "nummer3",
                Alladeltagarna = alladeltagarna
            };
            context.Tävling.Add(tävling);
            context.SaveChanges();
            Console.WriteLine("Hello World!");
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
            //QueryStringArray();
        }
        static void QueryStringArray()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            //Deltagare blah = context.Deltagare.Where(d => d.Namn == "Jonas Sköstätt").FirstOrDefault<Deltagare>();

            //can be used for ID ;) Apperently this is using LINQ
            //List<Deltagare> blah = context.Deltagare.Where(d => d.Namn == "Jonas Sköstätt").ToList<Deltagare>();
            List<Deltagare> blah = context.Deltagare.ToList<Deltagare>();

            // var list = from Name in blah select Name;
            Console.WriteLine("Yo");
        }

    }
}
