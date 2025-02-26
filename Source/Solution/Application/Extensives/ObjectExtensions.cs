namespace Application.Extensives;

/// <summary>
/// Provides extension methods 
/// for <see cref="object"/>.
/// </summary>
public static class ObjectExtensions
{
	/// <summary>
	/// Checks if an 
	/// object is null.
	/// </summary>
	public static bool IsNull(this object value) =>
		value is null;
}