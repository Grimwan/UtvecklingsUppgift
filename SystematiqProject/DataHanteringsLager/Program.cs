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
            QueryStringArray();
        }
        static void QueryStringArray()
        {
            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();
            var blah = context.Deltagare;
            var list = from Name in blah select Name;
            Console.WriteLine("Yo");
        }

    }
}
