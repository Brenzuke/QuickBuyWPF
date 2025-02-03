namespace Domain.Exceptions;

public sealed class PropertyNegativeException(string propertyName)
	: Exception($"The field '{propertyName}' doesn't allow negative values!");