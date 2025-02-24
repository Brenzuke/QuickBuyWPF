namespace Application.Extensives;

/// <summary>
/// Contains extension methods for <see cref="short"/> type, 
/// allowing comparisons to be made in a more 
/// expressive and reusable manner
/// </summary>
public static class ShortExtensions
{

	/// <summary>
	/// Extension method that checks if 
	/// a <see cref="short"/> value is 
	/// negative (less than zero)
	/// </summary>
	public static bool IsNegative(this short value) => value < 1;
}