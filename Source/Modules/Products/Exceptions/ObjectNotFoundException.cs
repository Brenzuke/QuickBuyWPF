namespace Products.Exceptions;

/// <summary>
/// Exceção personalizada 
/// para objetos não encontrado
/// </summary>
public sealed class ObjectNotFoundException<T>()
	: Exception($"O modelo '{typeof(T).Name}' não foi encontrado!");