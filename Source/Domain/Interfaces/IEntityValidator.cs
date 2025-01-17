namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for validating 
/// entities before performing operations.
/// </summary>
public interface IEntityValidator<T, N>
	where T : BaseObject
	where N : BaseNotify
{
	/// <summary>
	/// Validates the given entity, 
	/// ensuring it meets the required business rules.
	/// Returns a notification result indicating success or failure.
	/// </summary>
	N OnValidate(T entity);
}