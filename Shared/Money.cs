namespace Shared;

/// <summary>
/// Represents a monetary value with a currency and an amount.
/// </summary>
/// <param name="Currency">The currency of the monetary value.</param>
/// <param name="Amount">The amount of the monetary value.</param>
public record Money(string Currency, decimal Amount);