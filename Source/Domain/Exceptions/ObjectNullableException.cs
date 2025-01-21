namespace Domain.Exceptions;

/// <summary>
/// Exception thrown when an object is null.
/// This exception indicates a specific object.
/// </summary>
public sealed class ObjectNullableException<T>()
	: Exception($"The field '{typeof(T).Name}' can't be null!");