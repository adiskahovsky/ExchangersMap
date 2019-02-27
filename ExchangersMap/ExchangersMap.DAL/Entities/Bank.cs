
using ExchangersMap.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace ExchangersMap.DAL.Entities
{
    public class Bank : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime DateUpdate { get; set; }
        public virtual BankName Name { get; set; }


        public virtual ICollection<Departmen> Departaments { get; set; }
        public virtual ICollection<Currency> Currencies { get; set; }


    }
}
