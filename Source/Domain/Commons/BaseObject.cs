namespace Domain.Commons;

/// <summary>
/// Object for persistence in the database.
/// </summary>
public abstract class BaseObject
{
	/// <summary>
	/// Foreign key.
	/// </summary>
	public short Id { get; set; }
}