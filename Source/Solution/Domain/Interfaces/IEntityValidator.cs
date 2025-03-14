namespace Domain.Interfaces;

using Domain.Common;

public interface IEntityValidator<T> where T : BaseEntity
{
	void Validate(T entity);
}