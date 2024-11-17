# Checkout

# Checkout System

This project is a checkout system for a supermarket, built using .NET 8. The system handles items, prices, and applies special pricing rules for specific products.
## Overview

In a supermarket, items are represented by unique Stock Keeping Units (SKUs), and our checkout system uses letters to identify them (e.g., A, B, C, D). The items have individual prices, and some of them have special pricing rules, such as "3 for 130" or "2 for 45". This project includes:

- Core checkout logic for scanning items and calculating total price.
- Special pricing rules for some items.
- Unit tests to validate the system using TDD.

### Pricing Rules

- **Item A**: Unit Price = 50, Special Price = 3 for 130
- **Item B**: Unit Price = 30, Special Price = 2 for 45
- **Item C**: Unit Price = 20, No special price
- **Item D**: Unit Price = 15, No special price

## Project Structure

The project contains two main parts:

1. **CheckoutSystem** (Class Library):
   - Contains core logic and interfaces for the checkout system.
   - Includes models, services, and factories.

2. **CheckoutSystem.Tests** (Unit Test Project):
   - Contains unit tests for the checkout system.
   - Written using NUnit for effective TDD.

### Folder Structure

```
CheckoutSystem/
  ├── Interfaces/
  │     └── ICheckout.cs
  ├── Models/
  │     └── PricingRule.cs
  ├── Services/
  │     └── Checkout.cs
  ├── DataFactory/
  │     └── PricingRuleFactory.cs

CheckoutSystem.Tests/
  ├── Tests/
  │     └── CheckoutTests.cs

```

## Setup Instructions

1. **Clone the Repository**:
   ```sh
   git clone <repository-url>
   ```

2. **Open the Solution**:
   - Open `CheckoutSystem.sln` in Visual Studio.

3. **Run Tests**:
   - To verify that everything is working as expected, run all unit tests using Visual Studio Test Explorer.

## Usage

- **Scan an Item**: The checkout system allows scanning items using the `Scan()` method.
- **Calculate Total Price**: Use `GetTotalPrice()` to get the total cost of scanned items, considering both unit and special pricing.

### Example Usage

```csharp
var pricingRules = PricingRuleFactory.GetPricingRules();
ICheckout checkout = new Checkout(pricingRules);

checkout.Scan("A");
checkout.Scan("B");
checkout.Scan("A");
checkout.Scan("A");
checkout.Scan("B");

int total = checkout.GetTotalPrice(); // Expected total: 175
```

## Test Cases

We have several unit tests that ensure the correctness of the pricing rules and checkout calculations, including:

- **No items scanned**: Total should be `0`.
- **Single item scanned**: Correct unit price is returned.
- **Mixed items with special pricing**: Calculates the correct total considering applicable special prices.
- **Multiple items with and without special pricing**: Tests different combinations of items, including mixed pricing scenarios.



