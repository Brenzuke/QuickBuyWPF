namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for implementingoperations, 
/// including adding, updating, and removing objects from a collection.
/// </summary>
public interface IUnitOfWork<T>
	where T : BaseObject
{
	/// <summary>
	/// Adds a new object to the collection.
	/// </summary>
	T Insert(T entity);

	/// <summary>
	/// Get the object to the collection.
	/// </summary>
	T GetById(short id);

	/// <summary>
	/// Removes an object from the collection.
	/// </summary>
	T Delete(T entity);
}