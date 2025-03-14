﻿namespace Domain.Exceptions;

using System;

/// <summary>
/// Exception thrown when 
/// property constraint violations.
/// </summary>
internal sealed class PropertyConstraintException(string message) : Exception(message);