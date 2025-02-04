namespace Components.Exceptions;

using System;

/// <summary>
/// Exceção personalizada para indicar 
/// que uma propriedade violou uma restrição
/// </summary>
public sealed class PropertyConstraintException(string message) : Exception(message);