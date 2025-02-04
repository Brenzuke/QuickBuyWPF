namespace Components.Exceptions;

using System;

/// <summary>
/// Exceção personalizada 
/// ao encontrar valores negativos
/// </summary>
public sealed class PropertyNegativeException<T>()
	: Exception($"O campo '{typeof(T).Name}' não permite valor negativo!");