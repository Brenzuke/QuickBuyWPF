namespace Domain.Extensions;

internal static class DecimalExtensions
{
	public static bool IsNegative(this decimal value) => value < 0;
}