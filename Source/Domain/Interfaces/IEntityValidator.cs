namespace Domain.Interfaces;

using Domain.Common;

/// <summary>
/// Defines a contract for validating entities.
/// To implement, the class must inherit from
/// <see cref="BaseObject"/>
/// </summary>
public interface IEntityValidator<T> where T : BaseObject
{
	/// <summary>
	/// This method should contain logic to ensure 
	/// the entity is valid based on its business rules.
	/// </summary>
	void OnValidate(T entity);
}