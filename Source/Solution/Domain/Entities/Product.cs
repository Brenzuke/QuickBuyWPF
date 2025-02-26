namespace Domain.Entities;

using Domain.Common;

/// <summary>
/// Represents a product with name, price, and quantity.
/// </summary>
public sealed class Product : BaseObject
{
	/// <summary>
	/// Product price, must be positive.
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// Product quantity in stock, must be positive.
	/// </summary>
	public short Quantity { get; set; }

	/// <summary>
	/// Total value based on price and quantity.
	/// </summary>
	public decimal SubTotal => Price * Quantity;
}