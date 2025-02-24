namespace Domain.Entities;

using Domain.Common;

/// <summary>
/// Represents a product in the system.
/// Contains essential information such 
/// as the name, price, quantity.
/// </summary>
public sealed class Product : BaseObject
{
	/// <summary>
	/// The price must be a positive value, 
	/// used to calculate the total of transactions.
	/// Allows retrieval or modification.
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// The quantity must be a positive value,
	/// represents the current stock of the 
	/// product in the store. Allows 
	/// retrieval or modification.
	/// </summary>
	public short Quantity { get; set; }

	/// <summary>
	/// Returns a string representation 
	/// of the product with its details
	/// </summary>
	public override string ToString() =>
		$"Nome: {Name}\n" +
		$"Preço: {Price:C}\n" +
		$"Quantidade: {Quantity}\n";
}