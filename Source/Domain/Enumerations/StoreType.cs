namespace Domain.Enumerations;

/// <summary>
/// Enum that represents different types of stores.
/// Each value corresponds to a specific store category in the system.
/// </summary>
public enum StoreType : byte
{
	/// <summary>
	/// Represents a pharmacy store 
	/// where can purchase medications, 
	/// health products, and personal care items.
	/// </summary>
	Pharmacy = 1,

	/// <summary>
	/// Represents an online store,
	/// a digital platform where can purchase 
	/// a variety of products through the internet.
	/// </summary>
	OnlineStore = 2,

	/// <summary>
	/// Represents a supermarket, 
	/// a large retail store that sells 
	/// a wide variety of food and household products.
	/// </summary>
	Supermarket = 3
}