namespace Domain.Exceptions;

using System;

/// <summary>
/// Represents an exception
/// that is thrown when an entity 
/// cannot be found.
/// </summary>
public sealed class EntityNotFoundException(string message)
	: Exception(message);