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
	/// <exception cref="PropertyRequiredException"></exception>
	/// <exception cref="PropertyConstraintException"></exception>
	public void Validate(Product entity)
	{

		Validator(entity);
		PriceValidator(entity);
		QuantityValidator(entity);
	}

	/// <summary>
	/// The basic properties 
	/// of the Product entity
	/// </summary>
	private static void Validator(Product entity)
	{
		if (entity.Name.IsNull()) throw new PropertyRequiredException("The name is required!");
		if (entity.Store.IsDefined()) throw new PropertyRequiredException("The store doesn't have a valid option!");
	}

	/// <summary>
	/// The price is not negative
	/// and is greater than zero
	/// </summary>
	private static void PriceValidator(Product entity)
	{
		if (entity.Price.IsNegative()) throw new PropertyRequiredException("The price is required!");
		if (entity.Price.GreaterThan(1.0m)) throw new PropertyRequiredException("The price must be greater than zero!");
	}

	/// <summary>
	/// The quantity is not negative
	/// and is greater than zero
	/// </summary>
	private static void QuantityValidator(Product entity)
	{
		if (entity.Quantity.IsNegative()) throw new PropertyConstraintException("The quantity is required!");
		if (entity.Quantity.GreaterThan(1)) throw new PropertyConstraintException("The quantity must be greater than zero!");
	}
}