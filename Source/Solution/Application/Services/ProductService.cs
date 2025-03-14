namespace Application.Services;

using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;

public sealed class ProductService(IProductRepository repository)
{
	public void AddExecute(Product entity) => repository.Add(entity);

	public IEnumerable<Product> GetAllExecute() => repository.GetAll();

	public Product GetByNameExecute(string name) => repository.GetByName(name);

	public void DeleteByNameExecute(string name) => repository.DeleteByName(name);
}