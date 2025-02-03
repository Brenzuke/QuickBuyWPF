namespace Domain.Exceptions;

public sealed class UndefinedEnumException(string propertyName)
	: Exception($"The field '{propertyName}' has an undefined value!");