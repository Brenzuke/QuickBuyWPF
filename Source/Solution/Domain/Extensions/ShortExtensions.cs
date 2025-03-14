namespace Domain.Extensions;

/// <summary>
/// Provides extension methods for short.
/// </summary>
internal static class ShortExtensions
{
	/// <summary>
	/// Checks if a value is negative.
	/// </summary>
	public static bool IsNegative(this short value) => value < 0;
}