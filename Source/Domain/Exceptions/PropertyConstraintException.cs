namespace Domain.Exceptions;

using System;

/// <summary>
/// Represents an exception 
/// that is thrown when a property 
/// violates a constraint during validation.
/// </summary>
public sealed class PropertyConstraintException(string message) : Exception(message);