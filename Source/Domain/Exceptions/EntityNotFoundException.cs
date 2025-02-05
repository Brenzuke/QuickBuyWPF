namespace Domain.Exceptions;

using System;

public sealed class EntityNotFoundException(string message) : Exception(message);