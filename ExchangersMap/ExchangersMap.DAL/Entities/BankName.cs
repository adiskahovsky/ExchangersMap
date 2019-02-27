using ExchangersMap.DAL.Entities.Base;


namespace ExchangersMap.DAL.Entities
{
    public class BankName : IBaseEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
