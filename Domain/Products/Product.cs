using Shared;

namespace Domain.Products;

/// <summary>
/// Represents a product.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets the unique identifier for the product.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Gets the name for the product.
    /// </summary>
    public string Name { get; private set; } = String.Empty;
    
    /// <summary>
    /// Gets the price of the product, represented as a Money object.
    /// </summary>
    public Money? Price { get; private set; }

    public Sku? Sku { get; private set; }
}