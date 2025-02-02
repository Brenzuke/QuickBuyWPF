﻿namespace Domain.Commons;

/// <summary>
/// Object for notification 
/// to the user on the screen.
/// </summary>
public abstract class BaseNotify
{
	/// <summary>
	/// Reports an error message.
	/// </summary>
	protected string Message { get; set; }

	/// <summary>
	/// Indicates an error.
	/// </summary>
	protected bool IsFail { get; set; }

	/// <summary>
	/// Constructor simple.
	/// </summary>
	protected BaseNotify() { }

	/// <summary>
	/// Constructor with an error message.
	/// </summary>
	protected BaseNotify(string errorMessage) =>
		(IsFail, Message) = (true, errorMessage);
}