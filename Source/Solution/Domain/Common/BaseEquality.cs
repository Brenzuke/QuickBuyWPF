namespace Domain.Common;

using Domain.Exceptions;
using System;
using System.Collections.Generic;

public sealed class BaseEquality : IEqualityComparer<BaseEntity>
{
	public bool Equals(BaseEntity x, BaseEntity y) =>
		x is not null && y is not null && x.Name == y.Name;

	public int GetHashCode(BaseEntity obj) =>
		obj is null ? throw new HashCodeNullException(nameof(obj)) : HashCode.Combine(obj.Name);
}