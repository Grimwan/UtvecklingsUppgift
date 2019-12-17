using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHanteringsLager;

namespace SystematiqProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DataHanteringsLager.DataHanteringsLager data = new DataHanteringsLager.DataHanteringsLager();
            //Remove this commentary if you want to create a database and fill it with tävlingar and deltagare
            //data.BuildDeltagareAndTävlingDataBase();
            var tävlingsList = data.GetAllTävlingar();

            foreach (var tävling in tävlingsList)
            {
                Console.WriteLine("Tävlings namn: " + tävling.Namn);
                Console.WriteLine("Deltagarna i tävlingen");

                foreach(var deltagare in tävling.AllaDeltagarna)
                {
                    Console.WriteLine(deltagare.Namn);
                }
                Console.WriteLine("_______________________________");
            }
            Console.ReadKey();
        }
    }
}
