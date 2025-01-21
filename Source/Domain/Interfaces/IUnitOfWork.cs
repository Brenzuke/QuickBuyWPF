namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for implementingoperations, 
/// including adding, updating, and removing objects from a collection.
/// </summary>
public interface IUnitOfWork<T, N>
	where T : BaseObject
	where N : BaseNotify
{
	/// <summary>
	/// Adds a new object to the collection.
	/// </summary>
	N Insert(T entity);

	/// <summary>
	/// Get the object to the collection.
	/// </summary>
	N GetById(short id);

	/// <summary>
	/// Removes an object from the collection.
	/// </summary>
	N DeleteById(short id);
}