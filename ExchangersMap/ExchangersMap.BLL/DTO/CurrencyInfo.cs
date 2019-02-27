
using System.Collections.Generic;


namespace ExchangersMap.BLL.DTO
{
    public class CurrencyInfo
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Sell { get; set; }

        public decimal Buy { get; set; }
    }
}
