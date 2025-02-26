namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception for missing required properties.
/// </summary>
public sealed class PropertyRequiredException(string message) : Exception(message);