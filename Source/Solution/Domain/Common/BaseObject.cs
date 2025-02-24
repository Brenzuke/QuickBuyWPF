namespace Domain.Common;

using System;

/// <summary>
/// Base class for other entities.
/// Provides common properties such as
/// Id, CreatedAt, and UpdatedAt for 
/// tracking entity metadata.
/// </summary>
public abstract class BaseObject
{
	/// <summary>
	/// The name is a unique 
	/// and descriptive. Allows 
	/// retrieval or modification
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// The date and time when 
	/// the entity was created.
	/// Allows retrieval or modification.
	/// </summary>
	public DateTime CreatedAt { get; set; }
}