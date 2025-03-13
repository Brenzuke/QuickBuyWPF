namespace Domain.Entities;

using Domain.Common;

/// <summary>
/// Inherits common properties
/// from <see cref="BaseEntity"/>.
/// </summary>
public sealed class Product : BaseEntity
{
	/// <summary>
	/// Value must be greater than zero.
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// Value must be a positive number.
	/// </summary>
	public short Quantity { get; set; }

	/// <summary>
	/// Total value of the product stock, 
	/// calculated as <c>Price * Quantity</c>.
	/// </summary>
	public decimal SubTotal => Price * Quantity;
}