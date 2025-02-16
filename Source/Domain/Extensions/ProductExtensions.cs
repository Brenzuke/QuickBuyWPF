namespace Domain.Extensions;

using Domain.Enumerations;

/// <summary>
/// Extension methods for the 
/// Product class and related entities
/// </summary>
internal static class ProductExtensions
{
	/// <summary>
	/// Converts the StoreType 
	/// value to its Portuguese name
	/// </summary>
	internal static string ToPortuguese(this StoreType value)
	{
		return value switch
		{
			StoreType.Supermarket => "Supermercado",
			StoreType.Pharmacy => "Farmácia",
			StoreType.OnlineStore => "Loja Online",
			_ => "Unknown",
		};
	}
}