namespace Application.Services;

using Application.Interfaces;
using Application.Notifications;
using Domain.Entities;

/// <summary>
/// Sealed class that implements the Product service, 
/// providing operations for managing the Product entity.
/// </summary>
/// <param name="Products">Array of products.</param>
public sealed class ProductService(Product[] Products) : IProductService
{
	/// <summary>
	/// Adds a new object to the array.
	/// </summary>
	public ServiceMessage Insert(Product entity) =>
		new("Continue...");

	/// <summary>
	/// Get the object to the array.
	/// </summary>
	public ServiceMessage GetById(short id) =>
		new("Continue...");

	/// <summary>
	/// Removes an object from the array.
	/// </summary>
	public ServiceMessage DeleteById(short id) =>
		new("Continue...");
}