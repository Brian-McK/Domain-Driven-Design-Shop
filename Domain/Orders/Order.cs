using Domain.Customers;
using Domain.Products;
using Shared;

namespace Domain.Orders;

/// <summary>
/// Represents a customer order.
/// </summary>
public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    private Order()
    {
    }
    
    /// <summary>
    /// Gets the unique identifier for the order.
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// Gets the unique identifier for the customer who placed the order.
    /// </summary>
    public Guid CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order
        {
            Id = new Guid(),
            CustomerId = customer.Id,
        };

        return order;
    }

    /// <summary>
    /// Adds the specified product to the collection or list.
    /// </summary>
    /// <param name="product">The product to add.</param>
    public void Add(Product product)
    {
        LineItem lineItem = 
            new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
    }
}