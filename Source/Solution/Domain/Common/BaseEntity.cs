namespace Domain.Common;

using System;

public abstract class BaseEntity
{
	public string Name { get; set; }
	public DateTime CreatedAt { get; init; }
}