using ExchangersMap.DAL.Entities.Base;


namespace ExchangersMap.DAL.Entities
{
    public class CurrencyName : IBaseEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        
    }

}
