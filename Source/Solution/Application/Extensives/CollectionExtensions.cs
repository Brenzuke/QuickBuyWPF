namespace Application.Extensives;

using Domain.Common;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Contains extension methods for the <see cref="ICollection"/> type,
/// allowing comparisons to be made in a more 
/// expressive and reusable manner
/// </summary>
public static class CollectionExtensions
{
	/// <summary>
	/// Extension method that searches
	/// for an entity in the collection 
	/// by its <see cref="Name"/>
	/// </summary>
	public static T GetByName<T>(this ICollection<T> collections, string name) where T : BaseObject =>
		collections.FirstOrDefault(product => product.Name == name);
}