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
            var TestGetOne = test.GetTävling(6);
            Console.WriteLine("Hello World!");

        }
        static void BuildDeltagareDataBase()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            DataHanteringsLager test = new DataHanteringsLager();
            Deltagare Deltagare1 = new Deltagare()
            {
                Namn = "Jonas Filuren",
                Tävling = test.GetTävling(1)
        };
            Deltagare Deltagare2 = new Deltagare()
            {
                Namn = "Gustav Johnsson",
                Tävling = test.GetTävling(2)
            };
            Deltagare Deltagare3 = new Deltagare()
            {
                Namn = "Amanda Sörenson",
                Tävling = test.GetTävling(3)
            };
            Deltagare Deltagare4 = new Deltagare()
            {
                Namn = "Amanda Gustavsson",
                Tävling = test.GetTävling(4)
            };

            context.Deltagare.Add(Deltagare1);
            context.Deltagare.Add(Deltagare2);
            context.Deltagare.Add(Deltagare3);
            context.Deltagare.Add(Deltagare4);
            context.SaveChanges();
        }
        static void BuildTävlingDataBase()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();

            Tävling tävling1 = new Tävling()
            {
                Namn = "skidåkning1",
            };
            Tävling tävling2 = new Tävling()
            {
                Namn = "skidåkning2",
            };
            Tävling tävling3 = new Tävling()
            {
                Namn = "skidåkning3",
            };
            Tävling tävling4 = new Tävling()
            {
                Namn = "skidåkning4",
            };

            context.Tävling.Add(tävling1);
            context.Tävling.Add(tävling2);
            context.Tävling.Add(tävling3);
            context.Tävling.Add(tävling4);
            context.SaveChanges();
        }
    }
}
