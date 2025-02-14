namespace Application.Interfaces;

using Domain.Entities;
using Domain.Interfaces;

/// <summary>
/// Represents a contract for validating a Product entity.
/// This interface extends the IEntityValidator to 
/// ensure that product-specific validation 
/// logic is implemented
/// </summary>
public interface IProductValidator : IEntityValidator<Product>;