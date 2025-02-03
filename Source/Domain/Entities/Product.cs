namespace Domain.Entities;

using Domain.Commons;
using Domain.Enumerations;

public sealed class Product : BaseObject
{
	public string Name { get; init; }

	public decimal? Price { get; init; }

	public short? Quantity { get; init; }

	public StoreType? Store { get; init; }
}