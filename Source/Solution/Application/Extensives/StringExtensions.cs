namespace Application.Extensives;

/// <summary>
/// Contains extension methods for the <see cref="string"/> type, 
/// allowing common string operations to be performed in a more
/// convenient and reusable manner
/// </summary>
public static class StringExtensions
{
	/// <summary>
	/// Extension method that checks if 
	/// a <see cref="string"/> is null or 
	/// contains only white-space characters
	/// </summary>
	public static bool IsNull(this string value)
		=> string.IsNullOrWhiteSpace(value);
}