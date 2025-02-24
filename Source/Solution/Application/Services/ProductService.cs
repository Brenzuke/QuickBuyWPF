﻿namespace Application.Services;

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
	private readonly HashSet<Product> _products = [];

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
	/// Retrieves the complete set of 
	/// products available in memory
	/// </summary>
	public ICollection<Product> GetAll() =>
		_products;

	/// <summary>
	/// Deletes a product by 
	/// its unique identifier
	/// </summary>
	public void DeleteByName(string name)
	{
		Product product = _products
			.GetByName(name);

		if (product.IsNull()) return;
		else _products.Remove(product);
	}
}