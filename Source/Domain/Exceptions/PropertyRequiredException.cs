namespace Domain.Exceptions;

using System;

/// <summary>
/// Represents an exception 
/// that is thrown when a property
/// is required during validation
/// </summary>
public sealed class PropertyRequiredException(string message) : Exception(message);