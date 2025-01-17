namespace Domain.Entities;

using Domain.Commons;
using Domain.Enumerations;

/// <summary>
/// Represents a product in the system.
/// </summary>
public sealed class Product : BaseObject
{
	/// <summary>
	/// This is the product's descriptive name, 
	/// such as "Apple iPhone 14".
	/// </summary>
	public string Name { get; init; }

	/// <summary>
	/// This value represents the cost of 
	/// the product in the store's currency.
	/// </summary>
	public decimal? Price { get; init; }

	/// <summary>
	/// This value is nullable to indicate 
	/// the possibility of an unspecified stock count.
	/// </summary>
	public short? Quantity { get; init; }

	/// <summary>
	/// <para>Pharmacy</para>
	/// <para>OnlineStore</para>
	/// <para>Supermarket</para>
	/// </summary>
	public StoreType Store { get; init; }
}