namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when 
/// properties with invalid characters.
/// </summary>
public sealed class UnsupportedPropertyException(string message) : Exception(message);