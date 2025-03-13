namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when an attempt
/// is made to calculate
/// a hash code null
/// </summary>
public sealed class EntityHashCodeNullException(string message) : Exception(message);