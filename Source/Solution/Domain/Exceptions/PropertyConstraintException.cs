namespace Domain.Exceptions;

using System;

internal sealed class PropertyConstraintException(string message) : Exception(message);