namespace Domain.Entities;

using Domain.Common;

/// <summary>
/// Inherits common properties
/// from <see cref="BaseEntity"/>.
/// </summary>
public sealed class Product : BaseEntity
{
	/// <summary>
	/// This value must be 
	/// greater than zero.
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// This value must be 
	/// a positive number.
	/// </summary>
	public short Quantity { get; set; }

	/// <summary>
	/// The total value of the product stock, 
	/// calculated as Price * Quantity.
	/// </summary>
	public decimal SubTotal => Price * Quantity;
}