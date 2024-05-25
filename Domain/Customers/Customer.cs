namespace Domain.Customers;

/// <summary>
/// Represents a customer.
/// </summary>
public class Customer
{
    /// <summary>
    /// Gets the unique identifier for the customer.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Gets the name for the customer.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the email for the customer.
    /// </summary>
    public string Email { get; private set; } = string.Empty;
}