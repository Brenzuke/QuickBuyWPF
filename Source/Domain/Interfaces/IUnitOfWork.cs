namespace Domain.Interfaces;

using Domain.Commons;


public interface IUnitOfWork<T> where T : BaseObject
{
	T Insert(T entity);

	T GetById(short id);

	bool DeleteById(short id);
}