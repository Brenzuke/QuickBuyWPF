namespace Domain.Common;

using System;

/// <summary>
/// Base class for entities 
/// with common metadata.
/// </summary>
public abstract class BaseObject
{
	/// <summary>
	/// Unique and descriptive name.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Entity creation timestamp.
	/// </summary>
	public DateTime CreatedAt { get; set; }
}