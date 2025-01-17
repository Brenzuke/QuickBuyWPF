namespace Domain.Exceptions;

/// <summary>
/// Exception thrown when 
/// a property has an undefined value.
/// This exception indicates that a specific property
/// </summary>
public sealed class UndefinedEnumException(string propertyName)
	: Exception($"The field '{propertyName}' has an undefined value!!");