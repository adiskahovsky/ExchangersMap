using System;
using ExchangersMap.DAL.Entities.Base;
using ExchangersMap.DAL.Repositories.Base;

namespace ExchangersMap.DAL.UnitOfWork.Base
{
	public interface IUnitOfWork : IDisposable
	{
		void Commit();
		IRepository<T> GetRepository<T>() where T : class, IBaseEntity;
	}
}
