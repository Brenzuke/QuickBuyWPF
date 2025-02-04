namespace Products.Models;

using Products.Enumerations;

/// <summary>
/// Representa uma mercadoria
/// </summary>
public sealed class Product
{
	/// <summary>
	/// Identificador
	/// </summary>
	public short? Id { get; set; }

	/// <summary>
	/// Nome
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Valor
	/// </summary>
	public decimal? Price { get; set; }

	/// <summary>
	/// Quantidade
	/// </summary>
	public short? Quantity { get; set; }

	/// <summary>
	/// <para>Farmácia</para>
	/// <para>Supermercado</para>
	/// <para>Loja online</para>
	/// </summary>
	public StoreType? Store { get; set; }
}
