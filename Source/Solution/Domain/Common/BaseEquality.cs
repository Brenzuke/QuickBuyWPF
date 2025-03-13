namespace Domain.Common;

using Domain.Exceptions;
using System;
using System.Collections.Generic;

/// <summary>
/// Provides equality 
/// comparison for <see cref="BaseEntity"/>
/// instances based on the <c>Name</c> property.
/// </summary>
public sealed class BaseEquality : IEqualityComparer<BaseEntity>
{
	/// <summary>
	/// Determines whether two 
	/// <see cref="BaseEntity"/> instances 
	/// are equal by comparingtheir Name properties.
	/// </summary>
	public bool Equals(BaseEntity x, BaseEntity y) =>
		!x.IsNull() && !y.IsNull() && x.Name == y.Name;

	/// <summary>
	/// Returns a hash code for the 
	/// specified <see cref="BaseEntity"/> 
	/// instance based on its Name property.
	/// </summary>
	public int GetHashCode(BaseEntity obj) =>
		obj.IsNull() ? throw new HashCodeNullException(nameof(obj)) : HashCode.Combine(obj.Name);
}