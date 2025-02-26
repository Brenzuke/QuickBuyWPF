namespace Domain.Interfaces;

using Domain.Common;
using System.Collections.Generic;

/// <summary>
/// Defines contract for entity persistence.
/// </summary>
public interface IUnitOfWork<T> where T : BaseObject
{
	/// <summary>
	/// Inserts a new entity.
	/// </summary>
	void Insert(T entity);

	/// <summary>
	/// Retrieves all entities.
	/// </summary>
	ICollection<T> GetAll();

	/// <summary>
	/// Deletes an entity by name.
	/// </summary>
	void DeleteByName(string name);
}