namespace Domain.Interfaces;

using Domain.Common;

public interface IEntityValidator<T> where T : BaseObject
{
	bool Validate(T domainObj);
}