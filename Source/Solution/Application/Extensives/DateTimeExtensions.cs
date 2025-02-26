namespace Application.Extensives;

using System;

/// <summary>
/// Provides extension methods for DateTime.
/// </summary>
public static class DateTimeExtensions
{
	/// <summary>
	/// Formatted creation date (dd/MM/yyyy).
	/// </summary>
	public static string ToFormattedBrazilianDate(this DateTime value) =>
		value.ToString("dd/MM/yyyy");
}