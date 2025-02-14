namespace Application.Extensives;

/// <summary>
/// Contains extension methods for <see cref="int"/> type, 
/// allowing comparisons to be made in a more 
/// expressive and reusable manner
/// </summary>
public static class NumericExtensions
{
	/// <summary>
	/// Extension method that checks if a <see cref="int"/> 
	/// value is negative (less than zero)
	/// </summary>
	public static bool IsNegative(this int value) => value < 1;
}