namespace Domain.Exceptions;

public sealed class ObjectNullableException(string propertyName)
	: Exception($"The field '{propertyName}' can't be null!");