namespace Domain.Exceptions;

using System;

internal sealed class UnsupportedPropertyException(string message)
	: Exception(message);