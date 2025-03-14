namespace Domain.Extensions;

using Domain.Common;

internal static class BaseExtensions
{
	public static bool IsNull(this BaseEntity value) => value is null;
}