namespace Domain.Interfaces;

using Domain.Entities;

public interface IProductService
{
	Product Insert(Product domain);

	Product GetById(short id);

	Product DeleteById(short id);
}