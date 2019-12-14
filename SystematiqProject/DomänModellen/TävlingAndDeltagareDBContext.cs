using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DomänModellen
{
    public class TävlingAndDeltagareDBContext : DbContext
    {
        public DbSet<Deltagare> Deltagare { get; set; }

        public DbSet<Tävling> Tävling { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //setting up fluent mapping. Tells that Tävling hasmany deltagare
            modelBuilder.Entity<Tävling>().HasMany(p => p.Alladeltagarna);

            //The ID in both Tävling and Deltagare will now be set as primary key. 
           /* modelBuilder.Properties()
                        .Where(p => p.Name == "ID")
                        .Configure(p => p.IsKey());*/
        }

    }
}
