namespace Domain.Interfaces;

using Domain.Common;
using System.Collections.Generic;

/// <summary>
/// Defines a repository for managing 
/// entities in a persistence store.
/// </summary>
internal interface IEntityRepository<T> where T : BaseEntity
{
	/// <summary>
	/// Inserts a new entity into the repository.
	/// </summary>
	/// <param name="entity">The entity to insert.</param>
	/// <exception cref="UnsavedEntityException">
	/// Thrown if the provided entity is null.
	/// </exception>
	void Add(T entity);

	/// <summary>
	/// Retrieves an entity by its name from the repository.
	/// </summary>
	/// <param name="name">The name of the entity to retrieve.</param>
	/// <returns>The entity that matches the specified name.</returns>
	/// <exception cref="EntityNotFoundException">
	/// Thrown if no entity with the specified name is found.
	/// </exception>
	T GetByName(string name);

	/// <summary>
	/// Retrieves all entities from the repository.
	/// </summary>
	/// <returns>
	/// An <see cref="IEnumerable{T}"/> containing all entities.
	/// Returns an empty collection if no entities are found.
	/// </returns>
	IEnumerable<T> GetAll();

	/// <summary>
	/// Deletes an entity by its name from the repository.
	/// </summary>
	/// <param name="entity">The entity to be deleted.</param>
	/// <exception cref="EntityNotFoundException">
	/// Thrown if no entity with the specified name is found.
	/// </exception>
	void DeleteByName(string name);
}