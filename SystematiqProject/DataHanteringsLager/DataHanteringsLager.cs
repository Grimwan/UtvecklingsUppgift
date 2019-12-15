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

    }
}
