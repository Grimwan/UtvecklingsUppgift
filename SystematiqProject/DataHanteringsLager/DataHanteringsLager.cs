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
            return context.Tävling.ToList<Tävling>();
        }
        public Tävling GetTävling(int ID)
        {
            TävlingAndDeltagareDBContext context = new TävlingAndDeltagareDBContext();
            return context.Tävling.Where(d => d.ID == ID).First<Tävling>();
        }

    }
}
