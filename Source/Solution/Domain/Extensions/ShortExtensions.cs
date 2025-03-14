namespace Domain.Extensions;

public static class ShortExtensions
{
	public static bool IsZero(this short value) => value == 0;

	public static bool IsNegative(this short value) => value < 0;
}