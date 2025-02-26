#pragma warning disable IDE0079
#pragma warning disable SYSLIB1045
namespace Application.Extensives;

using System;
using System.Text.RegularExpressions;

/// <summary>
/// Provides extension methods 
/// for <see cref="short"/>.
/// </summary>
public static class ShortExtensions
{
	/// <summary>
	/// Checks if a <see cref="short"/> 
	/// is negative.
	/// </summary>
	public static bool IsNegative(this short value)
		=> value < 1;

	/// <summary>
	/// Checks if a <see cref="short"/>
	/// contains only numbers.
	/// </summary>
	public static bool IsMatch(this short value) =>
		Regex.IsMatch(Convert.ToString(value), @"^\d+$");
}