namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when 
/// missing required properties.
/// </summary>
internal sealed class PropertyRequiredException(string message) : Exception(message);