namespace Application.Validations;

using Application.Extensives;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;

/// <summary>
/// A validator class responsible for validating the properties of the Product entity.
/// </summary>
public sealed class ProductValidator : IProductValidator
{
	/// <summary>
	/// Validates the properties of the 
	/// specified Product entity to ensure
	/// that they meet specific requirements
	/// </summary>
	public void OnValidate(Product entity)
	{
		if (entity.Name.IsNull()) throw new PropertyRequiredException("O nome é obrigatório!");
		if (entity.Price.IsNegative()) throw new PropertyRequiredException("O preço é obrigatório!");
		if (entity.Quantity.IsNegative()) throw new PropertyConstraintException("A quantidade é obrigatória!");
	}
}