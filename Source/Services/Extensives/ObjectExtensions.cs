namespace Application.Extensives;

/// <summary>
/// Provides extension methods for the <see cref="object"/> type.
/// These methods allow for additional functionality
/// to be added to the base object type
/// </summary>
public static class ObjectExtensions
{
	/// <summary>
	/// Checks if an object is null.
	/// This extension method allows you to easily 
	/// check if any object is null in a more readable way
	/// </summary>
	public static bool IsNull(this object value) => value is null;
}