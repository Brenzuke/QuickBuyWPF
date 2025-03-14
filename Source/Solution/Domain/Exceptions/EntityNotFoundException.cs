namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when an 
/// entity is not found in 
/// the repository.
/// </summary>
internal sealed class EntityNotFoundException(string message) : Exception(message);