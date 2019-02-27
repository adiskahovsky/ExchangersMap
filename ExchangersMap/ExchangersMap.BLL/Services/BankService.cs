using AutoMapper;
using ExchangersMap.BLL.DTO;
using ExchangersMap.BLL.Helpers;
using ExchangersMap.DAL.Entities;
using ExchangersMap.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangersMap.BLL.Services
{
    public class BankService
    {
        IMapper _mapper;



        public BankService()
        {
           
           
            var config = new MapperConfiguration(cfg=> {
                cfg.CreateMap<Bank, BankFullInfo>()
                .ForPath(p => p.Bank.Name, p => p.MapFrom(m => m.Name.Name))
                .ForPath(p => p.Currencies, p => p.MapFrom(m => m.Currencies))
                .ForPath(p => p.Departments, p => p.MapFrom(m => m.Departaments));


            });
            _mapper = config.CreateMapper();

        }

        public ResultOperationInfo Add(BankFullInfo bankDTO )
        {


            var item = _mapper.Map<Bank>(bankDTO);

            UnitOfWork uw = new UnitOfWork();
            var res = uw.GetRepository<Bank>().Add(item);

            return new ResultOperationInfo(true, "Банк успешно добавлен"); 

        }

    }
}
