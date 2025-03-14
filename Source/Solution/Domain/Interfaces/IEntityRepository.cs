namespace Domain.Interfaces;

using Domain.Common;
using System.Collections.Generic;

internal interface IEntityRepository<T> where T : BaseEntity
{
	void Add(T entity);
	T GetByName(string name);
	IEnumerable<T> GetAll();
	void DeleteByName(string name);
}