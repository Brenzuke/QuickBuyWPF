namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when properties 
/// with invalid characters.
/// </summary>
internal sealed class UnsupportedPropertyException(string message) : Exception(message);