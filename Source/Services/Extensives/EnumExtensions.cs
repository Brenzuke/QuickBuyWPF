namespace Services.Extensives;

using System;

/// <summary>
/// Contains extension methods for <see cref="Enum"/> type, 
/// allowing additional functionality to be added to enum 
/// values in a more convenient and reusable manner
/// </summary>
public static class EnumExtensions
{
	/// <summary>
	/// Extension method that checks 
	/// if a value is defined within an enum
	/// </summary>
	public static bool IsDefined<TEnum>(this TEnum value) where TEnum : Enum
		=> Enum.IsDefined(typeof(TEnum), value);
}