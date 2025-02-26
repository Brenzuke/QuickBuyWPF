namespace Application.Services;

using Application.Extensives;
using Application.Interfaces;
using Domain.Common;
using Domain.Entities;
using Domain.Extensives;
using System.Collections.Generic;

/// <summary>
/// Manages product operations, preventing duplicates.
/// </summary>
public sealed class ProductService : IProductService
{
	/// <summary>
	/// Stores products in a 
	/// <see cref="HashSet{T}"/>.
	/// </summary>
	public ISet<Product> Products { get; private set; } =
		new HashSet<Product>(new ProductComparer());

	/// <summary>
	/// Adds a product if it's not null.
	/// </summary>
	public void Insert(Product entity)
	{
		if (entity.IsNull()) return;
		Products.Add(entity);
	}

	/// <summary>
	/// Returns all stored products.
	/// </summary>
	public IEnumerable<Product> GetAll() =>
		Products;

	/// <summary>
	/// Removes a product by name.
	/// </summary>
	public void DeleteByName(string name)
	{
		Product product = Products.GetByName(name);
		if (product.IsNull()) return;
		Products.Remove(product);
	}
}