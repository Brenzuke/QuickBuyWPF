namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception for property 
/// constraint violations.
/// </summary>
public sealed class PropertyConstraintException(string message) : Exception(message);