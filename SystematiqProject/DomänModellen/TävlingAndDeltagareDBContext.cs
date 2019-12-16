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
            //fluent mapping sets up a foreignkey on tävlingsId.
            modelBuilder.Entity<Deltagare>().HasRequired(c => c.Tävling).WithMany(d => d.Alladeltagarna).HasForeignKey(d => new { d.TävlingsId});

           

            //The ID in both Tävling and Deltagare will now be set as primary key. //this is probebly not necessary since the migration already specifys this
           /* modelBuilder.Properties()
                        .Where(p => p.Name == "ID")
                        .Configure(p => p.IsKey());*/
        }

    }
}
