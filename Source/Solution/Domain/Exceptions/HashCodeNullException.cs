namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when 
/// an attempt is made to 
/// calculate a hash code null
/// </summary>
internal sealed class HashCodeNullException(string message) : Exception(message);