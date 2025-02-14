#pragma warning disable IDE0044
namespace Application.Services;

using Application.Extensives;
using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Service class responsible for 
/// managing product operations. This class 
/// implements the IProductService interface 
/// </summary>
public sealed class ProductService : IProductService
{
	/// <summary>
	/// Optado por não possuir produtos duplicados
	/// </summary>
	private HashSet<Product> _products = [];

	/// <summary>
	/// Inserts a new product into the 
	/// product collection if it's not null
	/// </summary>
	public void Insert(Product entity)
	{
		if (entity.IsNull()) return;
		else _products.Add(entity);
	}

	/// <summary>
	/// Retrieves a product by 
	/// its unique identifier
	/// </summary>
	public Product GetByName(string name) =>
		_products.FirstOrDefault(product => product.Name == name);

	/// <summary>
	/// Retrieves the complete set of 
	/// products available in memory
	/// </summary>
	public ISet<Product> GetAll() =>
		_products;

	/// <summary>
	/// Deletes a product by 
	/// its unique identifier
	/// </summary>
	public void DeleteByName(string name) =>
		_products.Remove(GetByName(name));
}