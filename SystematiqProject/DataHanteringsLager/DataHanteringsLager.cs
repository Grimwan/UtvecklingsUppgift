using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomänModellen;


namespace DataHanteringsLager
{
    public class DataHanteringsLager
    {
        public List<Tävling> GetAllTävlingar()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();

            var tävlingsList = context.Tävling.ToList<Tävling>();

            foreach (var tävling in tävlingsList){
                tävling.AllaDeltagarna = context.Deltagare.Where(d => d.TävlingsID == tävling.ID).ToList<Deltagare>();
            }
            
            return tävlingsList;
        }
        public Tävling GetTävling(int ID)
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();

            var tävling = context.Tävling.Where(d => d.ID == ID).FirstOrDefault<Tävling>();
            if(tävling != null)
                tävling.AllaDeltagarna = context.Deltagare.Where(d => d.TävlingsID == tävling.ID).ToList<Deltagare>();

            return tävling;
        }

         //This function will generate a database with Tävlingar and Deltagare.
        public void BuildDeltagareAndTävlingDataBase()
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            Tävling tävling1 = new Tävling()
            {
                Namn = "Skidåkning",
            };
            Deltagare deltagare1 = new Deltagare()
            {
                Namn = "Jonas Filuren",
                Tävling = tävling1
            };

            Deltagare deltagare2 = new Deltagare()
            {
                Namn = "Gustav Johnsson",
                Tävling = tävling1
            };

            Tävling tävling2 = new Tävling()
            {
                Namn = "Snowboarding",
            };
            Deltagare deltagare3 = new Deltagare()
            {
                Namn = "Amanda Sörenson",
                Tävling = tävling2
            };

            Tävling tävling3 = new Tävling()
            {
                Namn = "Ishockey",
            };
            Deltagare deltagare4 = new Deltagare()
            {
                Namn = "Amanda Gustavsson",
                Tävling = tävling3
            };

            context.Deltagare.Add(deltagare1);
            context.Deltagare.Add(deltagare2);
            context.Deltagare.Add(deltagare3);
            context.Deltagare.Add(deltagare4);
            context.SaveChanges();
        }
    }
}
