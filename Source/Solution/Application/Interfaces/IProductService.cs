namespace Application.Interfaces;

using Domain.Entities;
using Domain.Interfaces;

/// <summary>
/// Defines service operations for products,  
/// extending <see cref="IUnitOfWork{T}"/>.
/// </summary>
public interface IProductService : IUnitOfWork<Product>;