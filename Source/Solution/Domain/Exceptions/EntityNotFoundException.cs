namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when an 
/// entity is not found in 
/// the repository.
/// </summary>
public sealed class EntityNotFoundException(string message) : Exception(message);