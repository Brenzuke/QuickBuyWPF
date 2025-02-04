namespace Products.Exceptions;

/// <summary>
/// Exceção personalizada 
/// ao encontrar enumeradores desconhecido
/// </summary>
public sealed class UndefinedEnumException<T>()
	: Exception($"O campo '{typeof(T).Name}' não possui valor definido!");