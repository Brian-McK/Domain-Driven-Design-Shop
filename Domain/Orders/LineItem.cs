using Shared;

namespace Domain.Orders;

/// <summary>
/// Represents a line item.
/// </summary>
public class LineItem
{
    /// <summary>
    /// Initializes a new instance of the LineItem class with the specified ID, order ID, product ID, and price.
    /// </summary>
    /// <param name="id">The unique identifier for the line item.</param>
    /// <param name="orderId">The unique identifier for the order to which the line item belongs.</param>
    /// <param name="productId">The unique identifier for the product associated with the line item.</param>
    /// <param name="price">The price of the line item, represented as a Money object.</param>
    internal LineItem(Guid id, Guid orderId, Guid productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

    /// <summary>
    /// Gets the unique identifier for the line item.
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// Gets the unique identifier for the order in a line item.
    /// </summary>
    public Guid OrderId { get; private set; }
    
    /// <summary>
    /// Gets the unique identifier for the product in a line item.
    /// </summary>
    public Guid ProductId { get; private set; }
    
    /// <summary>
    /// Gets the price for the order in a line item.
    /// </summary>
    public Money Price { get; private set; }
}