namespace Domain.Entities;

using Domain.Enumerations;

public sealed class Product
{
	public short? Id { get; set; }
	public string Name { get; set; }
	public decimal? Price { get; set; }
	public short? Quantity { get; set; }
	public StoreType? Store { get; set; }
}