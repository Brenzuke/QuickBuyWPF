namespace Domain.Validators;

using Domain.Entities;
using Domain.Exceptions;
using Domain.Extensions;
using Domain.Interfaces;

public sealed class ProductValidator : IEntityValidator<Product>
{
	public void Validate(Product entity)
	{
		if (entity.Price.IsZero()) throw new PropertyConstraintException("O preço deve possuir um valor!");
		if (entity.Price.IsNegative()) throw new PropertyConstraintException("O preço não pode ser negativo!");

		if (entity.Quantity.IsZero()) throw new PropertyConstraintException("A quantidade deve possuir um valor!");
		if (entity.Quantity.IsNegative()) throw new PropertyConstraintException("A quantidade não pode ser negativa!");
	}
}