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
            var TestGetAll = test.GetAllTävlingar();
            var TestGetOne = test.GetTävling(4);


            //BuildDeltagareAndTävlingDataBase();
            Console.WriteLine("endofFile!");
        }

        static void BuildDeltagareAndTävlingDataBase()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            DataHanteringsLager test = new DataHanteringsLager();
            Tävling tävling1 = new Tävling()
            {
                Namn = "Skidåkning",
            };
            Deltagare Deltagare1 = new Deltagare()
            {
                Namn = "Jonas Filuren",
                Tävling = tävling1
            };

            Deltagare Deltagare2 = new Deltagare()
            {
                Namn = "Gustav Johnsson",
                Tävling = tävling1
            };

            Tävling tävling2 = new Tävling()
            {
                Namn = "Snowboarding",
            };
            Deltagare Deltagare3 = new Deltagare()
            {
                Namn = "Amanda Sörenson",
                Tävling = tävling2
            };

            Tävling tävling3 = new Tävling()
            {
                Namn = "Ishockey",
            };
            Deltagare Deltagare4 = new Deltagare()
            {
                Namn = "Amanda Gustavsson",
                Tävling = tävling3
            };

            context.Deltagare.Add(Deltagare1);
            context.Deltagare.Add(Deltagare2);
            context.Deltagare.Add(Deltagare3);
            context.Deltagare.Add(Deltagare4);
            context.SaveChanges();
        }

      
    }
}
