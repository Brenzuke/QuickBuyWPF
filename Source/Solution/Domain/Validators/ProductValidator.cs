namespace Domain.Validators;

using Domain.Entities;
using Domain.Exceptions;
using Domain.Extensions;
using Domain.Interfaces;

/// <summary>
/// Provides validation services for <see cref="Product"/>.
/// This class implements the <see cref="IEntityValidator{Product}"/> interface.
/// </summary>
public sealed class ProductValidator : IEntityValidator<Product>
{
	/// <summary>
	/// Validates the specified <see cref="Product"/> entity.
	/// </summary>
	/// <param name="entity">The <see cref="Product"/> entity to validate.</param>
	/// <exception cref="PropertyConstraintException"></exception>
	public void Validate(Product entity)
	{
		if (entity.Price.IsNegative()) throw new PropertyConstraintException("O preço não pode ser negativo!");
		if (entity.Quantity.IsNegative()) throw new PropertyConstraintException("A quantidade não pode ser negativa!");
	}
}