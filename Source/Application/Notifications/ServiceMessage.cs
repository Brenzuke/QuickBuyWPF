namespace Application.Notifications;

using Domain.Commons;

/// <summary>
/// Message notification service.
/// </summary>
public sealed class ServiceMessage : BaseNotify
{
	/// <summary>
	/// Represents the entity 
	/// associated with the notification.
	/// </summary>
	internal BaseObject Object { get; set; }

	/// <summary>
	/// Constructor with an Object.
	/// </summary>
	internal ServiceMessage(BaseObject entity) =>
		(Object) = entity;

	/// <summary>
	/// Constructor with an error message.
	/// </summary>
	internal ServiceMessage(string errorMessage)
		: base(errorMessage) { }
}