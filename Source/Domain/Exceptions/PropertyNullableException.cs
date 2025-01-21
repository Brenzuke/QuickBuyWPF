namespace Domain.Exceptions;

/// <summary>
/// Exception thrown when 
/// a required property is missing or null.
/// This exception indicates that a specific property.
/// </summary>
public sealed class PropertyNullableException(string propertyName)
	: Exception($"The field '{propertyName}' can't null!");