

using ExchangersMap.DAL.Entities.Base;

namespace ExchangersMap.DAL.Entities
{
    public class Currency : IBaseEntity
    {
        public int Id { get; set; }

        public virtual CurrencyName Name { get; set; }

        public decimal Sell { get; set; }

        public decimal Buy { get; set; }
    }
}
