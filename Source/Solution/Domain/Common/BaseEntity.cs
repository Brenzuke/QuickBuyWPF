namespace Domain.Common;

using System;

/// <summary>
/// This class can be inherited to 
/// provide standard entity attributes.
/// </summary>
public abstract class BaseEntity
{
	/// <summary>
	/// This property should be
	/// descriptive and meaningful.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// This value is set at creation 
	/// and should not be modified.
	/// </summary>
	public DateTime CreatedAt { get; init; }
}