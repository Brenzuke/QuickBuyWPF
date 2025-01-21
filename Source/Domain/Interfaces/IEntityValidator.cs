namespace Domain.Interfaces;

using Domain.Commons;

/// <summary>
/// Base interface for validating 
/// entities before performing operations.
/// </summary>
public interface IEntityValidator<T> where T : BaseObject
{
	/// <summary>
	/// Validates the given entity, 
	/// ensuring it meets the required business rules.
	/// Returns a notification result indicating success or failure.
	/// </summary>
	void OnValidate(T entity);
}