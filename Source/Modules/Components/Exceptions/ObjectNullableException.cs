namespace Components.Exceptions;

using System;

/// <summary>
/// Exceção personalizada para objetos nulos
/// </summary>
public sealed class ObjectNullableException<T>()
	: Exception($"O campo '{typeof(T).Name}' não pode ser nulo!");