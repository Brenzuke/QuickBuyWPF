namespace Domain.Exceptions;

public sealed class PropertyNullableException(string propertyName)
	: Exception($"The field '{propertyName}' can't null!");