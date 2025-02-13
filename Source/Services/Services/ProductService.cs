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
public sealed class ProductService(ISet<Product> Products) : IProductService
{
	/// <summary>
	/// Inserts a new product into the 
	/// product collection if it's not null
	/// </summary>
	public void Insert(Product entity)
	{
		if (entity.IsNull()) return;
		else Products.Add(entity);
	}

	/// <summary>
	/// Retrieves a product by 
	/// its unique identifier
	/// </summary>
	public Product GetById(int id) =>
		Products.FirstOrDefault(product => product.Id == id);

	/// <summary>
	/// Deletes a product by 
	/// its unique identifier
	/// </summary>
	public void DeleteById(int id) =>
		Products.Remove(GetById(id));
}