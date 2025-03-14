namespace Domain.Extensions;

public static class DecimalExtensions
{
	public static bool IsZero(this decimal value) => value == 0;

	public static bool IsNegative(this decimal value) => value < 0;
}