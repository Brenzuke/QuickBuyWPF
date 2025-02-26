namespace Domain.Extensives;

/// <summary>
/// Provides extension methods for object.
/// </summary>
public static class ObjectExtensions
{
	/// <summary>
	/// Verifies if the object is null.
	/// </summary>
	public static bool IsNull(this object value) =>
		value is null;
}