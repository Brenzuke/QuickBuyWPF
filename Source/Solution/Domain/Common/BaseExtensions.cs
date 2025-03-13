namespace Domain.Common;

/// <summary>
/// Provides extension methods for 
/// the <see cref="BaseEntity"/> type.
/// </summary>
public static class BaseExtensions
{
	/// <summary>
	/// Determines whether the specified 
	/// <see cref="BaseEntity"/> is <c>null</c>.
	/// </summary>
	public static bool IsNull(this BaseEntity value) => value is null;
}