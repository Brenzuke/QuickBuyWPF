namespace Domain.Interfaces;

using Domain.Common;

internal interface IEntityValidator<T> where T : BaseEntity
{
	void Validate(T entity);
}