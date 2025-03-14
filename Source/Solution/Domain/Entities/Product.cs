namespace Domain.Entities;

using Domain.Common;

public sealed class Product : BaseEntity
{
	public decimal Price { get; set; }
	public short Quantity { get; set; }
	public decimal SubTotal => Price * Quantity;
}