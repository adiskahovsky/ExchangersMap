using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.BLL.DTO
{
    public class DepartmentInfo
    {

        public int Id { get; set; }
        public string Address { get; set; }

        public decimal LocX { get; set; }

        public decimal LocY { get; set; }
    }
}
