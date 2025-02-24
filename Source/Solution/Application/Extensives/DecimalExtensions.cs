namespace Application.Extensives;

/// <summary>
/// Contains extension methods for the <see cref="decimal"/> type,
/// allowing comparisons to be made in a more 
/// expressive and reusable manner
/// </summary>
public static class DecimalExtensions
{
	/// <summary>
	/// Extension method that checks if 
	/// a <see cref="decimal"/> value 
	/// is negative (less than zero)
	/// </summary>
	public static bool IsNegative(this decimal value) => value < 1;
}