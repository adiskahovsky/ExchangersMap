using ExchangersMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.DAL.Contexts
{
    public class ExchangersContext:DbContext
    {

        public ExchangersContext():base("ExchangersDb")
        {
                            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankName> BankNames { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Departmen> Departmens { get; set; }

        public DbSet<CurrencyName> CurrencyNames { get; set; }

        

    }
}
