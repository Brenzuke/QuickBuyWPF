namespace Domain.Commons;

/// <summary>
/// Object for notification to the user on the screen.
/// </summary>
public abstract class BaseNotify
{
	/// <summary>
	/// Reports an error message
	/// </summary>
	public string Message { get; set; }

	/// <summary>
	/// Indicates an error
	/// </summary>
	public bool IsFail { get; set; }
}