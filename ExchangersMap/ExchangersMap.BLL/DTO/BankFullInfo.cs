using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.BLL.DTO
{
    public class BankFullInfo
    {
        public BankInfo Bank { get; set; }

        public ICollection<CurrencyInfo> Currencies { get; set; }

        public ICollection<DepartmentInfo> Departments { get; set; }

    }
}
