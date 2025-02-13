namespace Services.Interfaces;

using Domain.Entities;
using Domain.Interfaces;

/// <summary>
/// Represents a contract for service operations related to the Product entity.
/// This interface extends the IUnitOfWork to provide a unified way to 
/// interact with the Product data in the context 
/// of transactional operations
/// </summary>
public interface IProductService : IUnitOfWork<Product>;