namespace Domain.Exceptions;

using System;

internal sealed class PropertyRequiredException(string message) : Exception(message);