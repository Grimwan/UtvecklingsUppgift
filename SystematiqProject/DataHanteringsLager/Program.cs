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
            var TestGetAll = test.GetAllT�vlingar();
            var TestGetOne = test.GetT�vling(6);
            Console.WriteLine("Hello World!");

        }
        static void BuildDeltagareDataBase()
        {
            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();
            DataHanteringsLager test = new DataHanteringsLager();
            Deltagare Deltagare1 = new Deltagare()
            {
                Namn = "Jonas Filuren",
                T�vling = test.GetT�vling(1)
        };
            Deltagare Deltagare2 = new Deltagare()
            {
                Namn = "Gustav Johnsson",
                T�vling = test.GetT�vling(2)
            };
            Deltagare Deltagare3 = new Deltagare()
            {
                Namn = "Amanda S�renson",
                T�vling = test.GetT�vling(3)
            };
            Deltagare Deltagare4 = new Deltagare()
            {
                Namn = "Amanda Gustavsson",
                T�vling = test.GetT�vling(4)
            };

            context.Deltagare.Add(Deltagare1);
            context.Deltagare.Add(Deltagare2);
            context.Deltagare.Add(Deltagare3);
            context.Deltagare.Add(Deltagare4);
            context.SaveChanges();
        }
        static void BuildT�vlingDataBase()
        {
            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();

            T�vling t�vling1 = new T�vling()
            {
                Namn = "skid�kning1",
            };
            T�vling t�vling2 = new T�vling()
            {
                Namn = "skid�kning2",
            };
            T�vling t�vling3 = new T�vling()
            {
                Namn = "skid�kning3",
            };
            T�vling t�vling4 = new T�vling()
            {
                Namn = "skid�kning4",
            };

            context.T�vling.Add(t�vling1);
            context.T�vling.Add(t�vling2);
            context.T�vling.Add(t�vling3);
            context.T�vling.Add(t�vling4);
            context.SaveChanges();
        }
    }
}
