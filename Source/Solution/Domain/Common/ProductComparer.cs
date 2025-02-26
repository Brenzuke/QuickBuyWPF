namespace Domain.Common;

using Domain.Entities;
using Domain.Extensives;
using System;
using System.Collections.Generic;

/// <summary>
/// Compares Product instances by name.
/// </summary>
public sealed class ProductComparer : IEqualityComparer<Product>
{
	/// <summary>
	/// Checks if two products are equal by name.
	/// </summary>
	public bool Equals(Product x, Product y) =>
		!x.IsNull() && !y.IsNull() && x.Name == y.Name;

	/// <summary>
	/// Generates a hash code based on the product name.
	/// </summary>
	public int GetHashCode(Product obj) =>
		obj is null ? throw new ArgumentNullException(nameof(obj)) : HashCode.Combine(obj.Name);
}