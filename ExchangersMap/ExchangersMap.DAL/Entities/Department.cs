

using ExchangersMap.DAL.Entities.Base;

namespace ExchangersMap.DAL.Entities
{
    public class Department : IBaseEntity
    {

        public int Id { get; set; }

        public string Address { get; set; }

        public decimal LocX { get; set; }

        public decimal LocY { get; set; }

  
    }
}
