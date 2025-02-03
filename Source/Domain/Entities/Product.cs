namespace Domain.Entities;

using Domain.Commons;
using Domain.Enumerations;

public sealed class Product : BaseObject
{
	public string Name { get; set; }

	public decimal? Price { get; set; }

	public short? Quantity { get; set; }

	public StoreType? Store { get; set; }
}