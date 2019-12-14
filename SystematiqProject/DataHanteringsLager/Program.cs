using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dom�nModellen;
namespace DataHanteringsLager
{
    class Program
    {
        static void Main(string[] args)
        {

            DataHanteringsLager test = new DataHanteringsLager();
            var blahh = test.GetAllT�vlingar();
            var blahhh = test.GetT�vling(1);

            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();

            List<Deltagare> alladeltagarna = context.Deltagare.ToList<Deltagare>();
            T�vling t�vling = new T�vling()
            {
                Namn = "nummer3",
                Alladeltagarna = alladeltagarna
            };
            context.T�vling.Add(t�vling);
            context.SaveChanges();
            Console.WriteLine("Hello World!");
            /*Deltagare deltagare = new Deltagare()
            {
                Namn = "Merry Kulenovic"
            };
            T�vling t�vling = new T�vling()
            {
                Namn = "yugioh",
                ID = 2
            };


            context.T�vling.Add(t�vling);
            context.SaveChanges();*/
            //QueryStringArray();
        }
        static void QueryStringArray()
        {
            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();
            //Deltagare blah = context.Deltagare.Where(d => d.Namn == "Jonas Sk�st�tt").FirstOrDefault<Deltagare>();

            //can be used for ID ;) Apperently this is using LINQ
            //List<Deltagare> blah = context.Deltagare.Where(d => d.Namn == "Jonas Sk�st�tt").ToList<Deltagare>();
            List<Deltagare> blah = context.Deltagare.ToList<Deltagare>();

            // var list = from Name in blah select Name;
            Console.WriteLine("Yo");
        }

    }
}
