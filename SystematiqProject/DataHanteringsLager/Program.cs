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
            var TestGetOne = test.GetT�vling(4);


            //BuildDeltagareAndT�vlingDataBase();
            Console.WriteLine("endofFile!");
        }

        static void BuildDeltagareAndT�vlingDataBase()
        {
            T�vlingAndDeltagareDBContext context = new T�vlingAndDeltagareDBContext();
            DataHanteringsLager test = new DataHanteringsLager();
            T�vling t�vling1 = new T�vling()
            {
                Namn = "Skid�kning",
            };
            Deltagare Deltagare1 = new Deltagare()
            {
                Namn = "Jonas Filuren",
                T�vling = t�vling1
            };

            Deltagare Deltagare2 = new Deltagare()
            {
                Namn = "Gustav Johnsson",
                T�vling = t�vling1
            };

            T�vling t�vling2 = new T�vling()
            {
                Namn = "Snowboarding",
            };
            Deltagare Deltagare3 = new Deltagare()
            {
                Namn = "Amanda S�renson",
                T�vling = t�vling2
            };

            T�vling t�vling3 = new T�vling()
            {
                Namn = "Ishockey",
            };
            Deltagare Deltagare4 = new Deltagare()
            {
                Namn = "Amanda Gustavsson",
                T�vling = t�vling3
            };

            context.Deltagare.Add(Deltagare1);
            context.Deltagare.Add(Deltagare2);
            context.Deltagare.Add(Deltagare3);
            context.Deltagare.Add(Deltagare4);
            context.SaveChanges();
        }

      
    }
}
