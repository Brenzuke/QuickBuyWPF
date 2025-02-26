namespace Application.Extensives;

using Domain.Common;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Provides extension methods for collections.
/// </summary>
public static class CollectionExtensions
{
	/// <summary>
	/// Finds entity by name, returns null if name is null.
	/// </summary>
	public static T GetByName<T>(this ICollection<T> collections, string name) where T : BaseObject =>
		collections.FirstOrDefault(product => product.Name == name && !product.Name.IsNull());
}