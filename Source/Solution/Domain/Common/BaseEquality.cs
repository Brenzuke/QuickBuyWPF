namespace Domain.Common;

using Domain.Exceptions;
using Domain.Extensions;
using System;
using System.Collections.Generic;

public sealed class BaseEquality : IEqualityComparer<BaseEntity>
{
	public bool Equals(BaseEntity x, BaseEntity y) =>
		!x.IsNull() && !y.IsNull() && x.Name == y.Name;

	public int GetHashCode(BaseEntity obj) =>
		obj.IsNull() ? throw new HashCodeNullException(nameof(obj)) : HashCode.Combine(obj.Name);
}