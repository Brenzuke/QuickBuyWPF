namespace Products.Interfaces;

using Domain.Entities;

public interface IProductService
{
	Product GetById(short id);

	void DeleteById(short id);

	void Insert(Product domain);
}