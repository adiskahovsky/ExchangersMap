using ExchangersMap.BLL.DTO;
using ExchangersMap.BLL.Helpers;
using ExchangersMap.DAL.Entities;
using ExchangersMap.DAL.Repositories;
using ExchangersMap.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace ExchangersMap.BLL.Services
{
    public class DepartmentService
    {

        public DepartmentService()
        {
            Mapper.Initialize(cfg=>cfg.CreateMap<Bank,DepartmentInfoDTO>()
            .ForPath(x=>x.BankName,m=>m.MapFrom(a=>a.Name.Name))
            .ForPath(x=>x.Currencies,m=>m.MapFrom(a=>a.Currencies))
            .ForPath(x=>x.Address,m=>m.MapFrom(a=>a.Departaments.Select(x=>x.Address)))
            .ForPath(x=>x.Currencies,m=>m.MapFrom(a=>a.Currencies)));  
        }

        public ResultOperationInfo<DepartmentInfoDTO> GetAll()
        {
            UnitOfWork uw = new UnitOfWork();


            var banks = uw.GetRepository<Bank>().GetAll().ToList(); ;
            return new ResultOperationInfo<DepartmentInfoDTO>(new DepartmentInfoDTO(), true, "Secseded");




        }
    }
}
