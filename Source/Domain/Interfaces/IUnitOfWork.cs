namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for implementingoperations, 
/// including adding, updating, and removing objects from a collection.
/// </summary>
public interface IUnitOfWork<T> where T : BaseObject
{
	/// <summary>
	/// Adds a new object to the collection.
	/// </summary>
	void Insert(T entity);

	/// <summary>
	/// Updates an existing object in the collection.
	/// </summary>
	void Update(T entity);

	/// <summary>
	/// Removes an object from the collection.
	/// </summary>
	void Delete(T entity);
}