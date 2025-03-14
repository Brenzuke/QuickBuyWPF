namespace Domain.Exceptions;

using System;

internal sealed class HashCodeNullException(string message) : Exception(message);