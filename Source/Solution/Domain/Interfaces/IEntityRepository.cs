namespace Domain.Interfaces;

using Domain.Common;
using System.Collections.Generic;

/// <summary>
/// This interface provides methods to insert, 
/// retrieve, and delete entities 
/// in a persistence store.
/// </summary>
public interface IEntityRepository<T> where T : BaseEntity
{
	/// <summary>
	/// Inserts a new entity.
	/// </summary>
	void Insert(T entity);

	/// <summary>
	/// Retrieves all entities.
	/// </summary>
	IEnumerable<T> GetAll();

	/// <summary>
	/// Deletes an entity by name.
	/// </summary>
	void DeleteByName(string name);
}