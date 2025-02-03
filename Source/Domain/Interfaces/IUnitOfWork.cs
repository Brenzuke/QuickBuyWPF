namespace Domain.Interfaces;

using Domain.Commons;


public interface IUnitOfWork<T, N>
	where T : BaseObject
{
	N Insert(T entity);

	N GetById(short id);

	N DeleteById(short id);
}