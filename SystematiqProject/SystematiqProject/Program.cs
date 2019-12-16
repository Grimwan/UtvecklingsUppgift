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
           
            DataHanteringsLager.DataHanteringsLager Data = new DataHanteringsLager.DataHanteringsLager();
            //Data.BuildDeltagareAndTävlingDataBase();
            var TävlingsList = Data.GetAllTävlingar();

            foreach (var tävling in TävlingsList)
            {
                Console.WriteLine("Tävlings Namn: " + tävling.Namn);
                Console.WriteLine("Deltagarna i tävlingen");

                foreach(var deltagare in tävling.Alladeltagarna)
                {
                    Console.WriteLine(deltagare.Namn);
                }
                Console.WriteLine("_______________________________");
            }
            Console.ReadKey();
        }
    }
}
