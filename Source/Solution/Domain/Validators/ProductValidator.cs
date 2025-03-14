namespace Domain.Validators;

using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;

public sealed class ProductValidator : IEntityValidator<Product>
{
	public void Validate(Product entity)
	{
		if (entity.Price < 0) throw new PropertyConstraintException("O preço não pode ser negativo!");
		if (entity.Price == 0) throw new PropertyConstraintException("O preço deve possuir um valor!");

		if (entity.Quantity < 0) throw new PropertyConstraintException("A quantidade não pode ser negativa!");
		if (entity.Quantity == 0) throw new PropertyConstraintException("A quantidade deve possuir um valor!");
	}
}