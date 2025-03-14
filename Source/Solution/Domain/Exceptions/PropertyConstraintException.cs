namespace Domain.Exceptions;

using System;

public sealed class PropertyConstraintException(string message)
	: Exception(message);