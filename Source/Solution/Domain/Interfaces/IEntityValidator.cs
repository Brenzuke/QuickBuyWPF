namespace Domain.Interfaces;

using Domain.Common;

/// <summary>
/// Defines a contract for validating 
/// entities of type <typeparamref name="T"/>.
/// </summary>
internal interface IEntityValidator<T> where T : BaseEntity
{
	/// <summary>
	/// Validates the specified entity.
	/// </summary>
	/// <param name="entity">The entity to be validated.</param>
	void Validate(T entity);
}