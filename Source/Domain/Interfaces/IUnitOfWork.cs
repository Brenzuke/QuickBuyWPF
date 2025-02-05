namespace Domain.Interfaces;

using Domain.Common;

public interface IUnitOfWork<T> where T : BaseObject
{
	T Insert(T domainObj);
	T GetById(T domainObj);
	bool DeleteById(T domainObj);
}