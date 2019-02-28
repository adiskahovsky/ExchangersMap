using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.BLL.DTO
{
    public class DepartmentInfoDTO
    {

        public string BankName { get; set; }
        public string Address { get; set; }

        public decimal LocX { get; set; }

        public decimal LocY { get; set; }
        public ICollection<CurrencyInfo> Currencies { get; set; }
    }
}
