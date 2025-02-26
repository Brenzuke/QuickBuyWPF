#pragma warning disable IDE0079
#pragma warning disable SYSLIB1045
namespace Application.Extensives;

using System.Text.RegularExpressions;

/// <summary>
/// Provides extension methods 
/// for <see cref="string"/>.
/// </summary>
public static class StringExtensions
{
	/// <summary>
	/// Checks if a 
	/// string is null or empty.
	/// </summary>
	public static bool IsNull(this string value) =>
		string.IsNullOrWhiteSpace(value);

	/// <summary>
	/// Checks if a string 
	/// contains only letters, 
	/// numbers, and spaces.
	/// </summary>
	public static bool IsMatch(this string value) =>
		Regex.IsMatch(value, @"^[a-zA-ZÀ-ÿ0-9\s]+$");

	/// <summary>
	/// Converts a 
	/// string to a decimal.
	/// </summary>
	public static decimal ToDecimal(this string value) =>
		decimal.TryParse(value, out decimal result) ? result : 0;

	/// <summary>
	/// Converts a 
	/// string to a short.
	/// </summary>
	public static short ToShort(this string value) =>
		short.TryParse(value, out short result) ? result : (short)0;
}