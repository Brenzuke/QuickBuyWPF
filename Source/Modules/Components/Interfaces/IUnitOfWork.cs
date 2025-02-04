namespace Components.Interfaces;

using Components.Commons;

/// <summary>
/// Interface genérico para CRUDs
/// </summary>
public interface IUnitOfWork<T> where T : BaseObject
{
	/// <summary>
	/// Permite adicionar
	/// </summary>
	void Insert(T entity);

	/// <summary>
	/// Obtém um objeto pelo ID
	/// </summary>
	T GetById(short id);

	/// <summary>
	/// Deleta um objeto pelo ID
	/// </summary>
	bool DeleteById(short id);
}