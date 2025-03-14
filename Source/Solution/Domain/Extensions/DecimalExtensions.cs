namespace Domain.Extensions;

/// <summary>
/// Provides extension methods decimal.
/// </summary>
internal static class DecimalExtensions
{
	/// <summary>
	/// Checks if a value value is negative.
	/// </summary>
	public static bool IsNegative(this decimal value) => value < 0;
}