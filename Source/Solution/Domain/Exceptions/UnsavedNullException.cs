namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when an entity
/// cannot be saved because 
/// it is null.
/// </summary>
internal sealed class UnsavedNullException(string message) : Exception(message);