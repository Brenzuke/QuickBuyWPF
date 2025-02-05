namespace Domain.Interfaces;

using Domain.Common;

/// <summary>
/// Defines a contract for manages 
/// the persistence operations entities.
/// To implement, the class must inherit from
/// <see cref="BaseObject"/>
/// </summary>
public interface IUnitOfWork<T> where T : BaseObject
{
	/// <summary>
	/// Inserts a new entity, which inherits
	/// from <see cref="BaseObject"/> 
	/// into the persistence store.
	/// </summary>
	void Insert(T entity);

	/// <summary>
	/// Retrieves an entity, which inherits
	/// from <see cref="BaseObject"/> 
	/// by its unique identifier.
	/// </summary>
	T GetById(T entity);

	/// <summary>
	/// Deletes an entity, which inherits 
	/// from <see cref="BaseObject"/>,
	/// by its unique identifier.
	/// </summary>
	void DeleteById(T entity);
}