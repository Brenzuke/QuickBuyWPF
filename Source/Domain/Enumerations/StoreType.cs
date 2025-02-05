namespace Domain.Enumerations;

/// <summary>
/// Represents the different types
/// of stores where a product can be sold.
/// </summary>
public enum StoreType : byte
{
	/// <summary>
	/// A pharmacy store type.
	/// </summary>
	Pharmacy = 1,

	/// <summary>
	/// A supermarket store type.
	/// </summary>
	Supermarket = 2,

	/// <summary>
	/// An online store type.
	/// </summary>
	OnlineStore = 3
}