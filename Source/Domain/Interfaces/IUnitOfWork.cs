namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for implementing operations, 
/// including adding, updating, and removing objects.
/// </summary>
public interface IUnitOfWork<T, N>
	where T : BaseObject
	where N : BaseNotify
{
	/// <summary>
	/// Adds a new object.
	/// </summary>
	N Insert(T entity);

	/// <summary>
	/// Get the object.
	/// </summary>
	N GetById(short id);

	/// <summary>
	/// Removes an object.
	/// </summary>
	N DeleteById(short id);
}