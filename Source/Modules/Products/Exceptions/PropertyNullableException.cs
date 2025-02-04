namespace Products.Exceptions;

/// <summary>
/// Exceção personalizada 
/// ao encontrar valores nulos
/// </summary>
public sealed class PropertyNullableException<T>()
	: Exception($"O campo '{typeof(T).Name}' é obrigatório!");