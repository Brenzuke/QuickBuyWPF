namespace Components.Exceptions;

using System;

/// <summary>
/// Exceção personalizada 
/// para objetos não encontrado
/// </summary>
public sealed class ObjectNotFoundException(string message) : Exception(message);