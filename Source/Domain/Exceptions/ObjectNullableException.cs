namespace Domain.Exceptions;

public sealed class ObjectNullableException<T>()
	: Exception($"The field '{typeof(T).Name}' can't be null!");