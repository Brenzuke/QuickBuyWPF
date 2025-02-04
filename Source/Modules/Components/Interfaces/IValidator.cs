namespace Components.Interfaces;

using Components.Commons;

/// <summary>
/// Interface para realizar
/// a validação de um objeto
/// </summary>
public interface IValidator<T> where T : BaseObject
{
	/// <summary>
	/// Executa a validação
	/// </summary>
	bool Validate(T @object);
}