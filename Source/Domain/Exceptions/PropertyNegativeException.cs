namespace Domain.Exceptions;

/// <summary>
/// Exception thrown when 
/// property that should has a non negative value.
/// This exception indicates that a specific property.
/// </summary>
public sealed class PropertyNegativeException(string propertyName)
	: Exception($"The field '{propertyName}' doesn't allow negative values!");