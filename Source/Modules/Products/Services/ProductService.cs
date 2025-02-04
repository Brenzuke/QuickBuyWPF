namespace Products.Services;

using Components.Exceptions;
using Components.Interfaces;
using Products.Models;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Serviço da mercadoria
/// </summary>
public sealed class ProductService(ISet<Product> products) : IUnitOfWork<Product>
{
	/// <summary>
	/// Adiciona numa coleção
	/// </summary>
	public void Insert(Product entity)
	{
		throw new System.NotImplementedException();
	}

	/// <summary>
	/// Obtém através do ID
	/// </summary>
	public Product GetById(short id)
	{
		// Busca o produto pelo ID
		Product product = products
			.Where(product => product.Id == id)
			.FirstOrDefault();

		// Caso a entidade existir retorna,
		// senão lança uma exceção personalizada
		if (product is not null) return product;
		throw new ObjectNotFoundException($"A mercadoria '{product.Name}' não foi encontrada!");
	}

	/// <summary>
	/// Remove atr
	/// </summary>
	public bool DeleteById(short id) =>
		products.Remove(GetById(id));
}