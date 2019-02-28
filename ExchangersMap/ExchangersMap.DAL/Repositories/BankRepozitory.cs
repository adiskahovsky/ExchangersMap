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
    public class BankRepozitory : GenericRepository<Bank>
    {
        public BankRepozitory(DbContext db ):base(db)
        {
                
        }
    }
}
