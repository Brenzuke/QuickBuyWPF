namespace Application.Extensives;

using Domain.Common;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Provides extension methods 
/// for <see cref="ICollection{T}"/>  
/// to enhance search functionality.
/// </summary>
public static class CollectionExtensions
{
	/// <summary>
	/// Finds an entity by its 
	/// <see cref="Name"/> in 
	/// the collection.
	/// </summary>
	public static T GetByName<T>(this ICollection<T> collections, string name) where T : BaseObject =>
		collections.FirstOrDefault(product => product.Name == name);
}