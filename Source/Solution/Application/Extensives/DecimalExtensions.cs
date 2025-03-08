﻿#pragma warning disable IDE0079
#pragma warning disable SYSLIB1045
namespace Application.Extensives;

using System;
using System.Text.RegularExpressions;

/// <summary>
/// Provides extension methods decimal.
/// </summary>
public static class DecimalExtensions
{
	/// <summary>
	/// Checks if a value value is negative.
	/// </summary>
	public static bool IsNegative(this decimal value)
		=> value < 1;

	/// <summary>
	/// Validates if a value contains only numbers.
	/// </summary>
	public static bool IsMatch(this decimal value)
		=> Regex.IsMatch(Convert.ToString(value), @"^[0-9]+([.,][0-9]+)?$");
}