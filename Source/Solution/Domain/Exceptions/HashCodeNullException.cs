namespace Domain.Exceptions;

using System;

public sealed class HashCodeNullException(string message)
	: Exception(message);