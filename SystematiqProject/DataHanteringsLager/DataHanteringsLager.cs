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

            var TävlingsList = context.Tävling.ToList<Tävling>();

            foreach (var tävling in TävlingsList){
                tävling.Alladeltagarna = context.Deltagare.Where(d => d.TävlingsId == tävling.ID).ToList<Deltagare>();
            }
            
            return TävlingsList;
        }
        public Tävling GetTävling(int ID)
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();

            var tävling = context.Tävling.Where(d => d.ID == ID).FirstOrDefault<Tävling>();
            if(tävling != null)
                tävling.Alladeltagarna = context.Deltagare.Where(d => d.TävlingsId == tävling.ID).ToList<Deltagare>();

            return tävling;
        }

         //This function will generate a database with Tävlingar and Deltagare.
        public void BuildDeltagareAndTävlingDataBase()
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
