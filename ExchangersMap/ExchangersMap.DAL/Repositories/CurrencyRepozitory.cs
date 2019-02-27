using ExchangersMap.DAL.Entities;
using ExchangersMap.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.DAL.Repositories
{
    internal class CurrencyRepozitory: GenericRepository<Currency>
    {

        public CurrencyRepozitory(DbContext db):base(db)
        {
                
        }
    }
}
