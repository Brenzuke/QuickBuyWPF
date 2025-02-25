namespace Application.Services;

using Application.Extensives;
using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;

/// <summary>
/// Service class responsible for 
/// managing product operations. This class 
/// implements the IProductService interface 
/// </summary>
public sealed class ProductService : IProductService
{
	/// <summary>
	/// A collection of products stored in 
	/// a <see cref="HashSet{T}"/> to 
	/// prevent duplicates
	/// </summary>
	public HashSet<Product> Products { get; private set; } = [];

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
	/// Retrieves the complete set of 
	/// products available in memory
	/// </summary>
	public ICollection<Product> GetAll() =>
		Products;

	/// <summary>
	/// Deletes a product by 
	/// its unique identifier
	/// </summary>
	public void DeleteByName(string name)
	{
		Product product = Products
			.GetByName(name);

		if (product.IsNull()) return;
		else Products.Remove(product);
	}
}