namespace Domain.Products;

/// <summary>
/// Represents a Stock Keeping Unit (SKU).
/// </summary>
public record Sku
{
    // A constant for the default length of a valid SKU.
    private const int DefaultLength = 15;
    private Sku(string value) => Value = value;
    public string Value { get; init; }

    /// <summary>
    /// Factory method to create a new Sku instance if the provided value is valid.
    /// </summary>
    /// <param name="value">The SKU value to validate and use for the new Sku instance.</param>
    /// <returns>A new Sku instance if the value is valid; otherwise, null.</returns>
    public static Sku? Create(string value)
    {
        return IsValidSku(value) ? new Sku(value) : null;
    }

    /// <summary>
    /// Validates if the provided SKU (Stock Keeping Unit) is valid.
    /// </summary>
    /// <param name="value">The SKU value to validate.</param>
    /// <returns>True if the SKU is valid; otherwise, false.</returns>
    private static bool IsValidSku(string value)
    {
        if (string.IsNullOrEmpty(value)) return false;
        return value.Length == DefaultLength;
    }
}
