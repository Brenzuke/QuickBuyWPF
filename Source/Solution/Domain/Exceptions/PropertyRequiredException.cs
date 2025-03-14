namespace Domain.Exceptions;

using System;

public sealed class PropertyRequiredException(string message)
	: Exception(message);