namespace Application.Interfaces;

using Application.Notifications;
using Domain.Entities;
using Domain.Interfaces;

/// <summary>
/// Interface that extends IUnitOfWork 
/// to manage basic operations for the Product entity.
/// </summary>
public interface IProductService : IUnitOfWork<Product, ServiceMessage>;