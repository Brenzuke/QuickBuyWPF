namespace Application.Validations;

using Domain.Entities;
using Domain.Enumerations;
using Domain.Exceptions;
using Domain.Interfaces;

/// <summary>
/// Validator for the Product entity
/// </summary>
public sealed class ProductValidator : IEntityValidator<Product>
{
	/// <summary>
	/// Performs the property validations
	/// </summary>
	/// <exception cref="PropertyNullableException"></exception>
	/// <exception cref="PropertyNegativeException"></exception>
	/// <exception cref="UndefinedEnumException"></exception>
	public void OnValidate(Product entity)
	{
		// The name cannot contain spaces or be null
		if (string.IsNullOrWhiteSpace(entity.Name))
			throw new PropertyNullableException(nameof(entity.Name));

		// The price must not be negative
		if (entity.Price <= 0)
			throw new PropertyNegativeException(nameof(entity.Price));

		// The quantity must not be negative
		if (entity.Quantity <= 0.0m)
			throw new PropertyNegativeException(nameof(entity.Quantity));

		// The enum value must match the values of StoreType
		if (!Enum.IsDefined(typeof(StoreType), entity.Store))
			throw new UndefinedEnumException(nameof(entity.Store));
	}
}