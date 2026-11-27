

using System;

namespace SalesAnalytics.App;

public record Customer(
    int Id,
    string Name,
    string Email
);

public record Product(
    int Id,
    string Name,
    int CategoryId,
    decimal Price
);

public record Category(
    int Id,
    string Name
);

public record Sale(
    int Id,
    int CustomerId,
    int ProductId,
    int Quantity,
    DateTime SaleDate
);