# Book Store Application - SOLID Principles in C#

This repository demonstrates the SOLID principles using a simple **Book Store** application in C#.

## Overview

The application follows the SOLID principles:

- **<span style="color: red;">S</span>**ingle Responsibility Principle (SRP): The `Book` and `Order` classes have distinct, single responsibilities.
- **<span style="color: red;">O</span>**pen/Closed Principle (OCP): Discounts are applied using the `Discount` abstract class, allowing easy extension of different discount types without modifying existing code.
- **<span style="color: red;">L</span>**iskov Substitution Principle (LSP): The `BookWithDiscount` class can be substituted for the `Book` class without affecting program behavior.
- **<span style="color: red;">I</span>**nterface Segregation Principle (ISP): Specific interfaces like `IOrderNotification` and `IOrderPayment` are created, adhering to focused interfaces.
- **<span style="color: red;">D</span>**ependency Inversion Principle (DIP): The `OrderProcessor` depends on abstractions (interfaces) rather than concrete implementations for notifications and payments.

## Project Structure

```
BookStoreApp/
│
├── Book.cs
├── BookWithDiscount.cs
├── Discount.cs
├── SeasonalDiscount.cs
├── NoDiscount.cs
├── Order.cs
├── OrderProcessor.cs
├── IOrderNotification.cs
├── IOrderPayment.cs
├── EmailNotification.cs
├── CreditCardPayment.cs
└── Program.cs
```

## How to Run

1. Clone the repository:

   ```bash
   git clone git@github.com:yasser-mohamed1/SOLID-Principles.git
   ```

2. Navigate to the project directory:

   ```bash
   cd SOLID
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

## Features

- Add books to an order.
- Apply discounts to books.
- Process payments with different methods.
- Notify customers via email when an order is placed.
