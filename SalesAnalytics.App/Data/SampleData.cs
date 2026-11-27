using System;
using System.Collections.Generic;

namespace SalesAnalytics.App.Data;

public static class SampleData
{
    public static readonly List<Category> Categories = new()
    {
        new Category(1, "Electronics"),
        new Category(2, "Books"),
        new Category(3, "Home"),
        new Category(4, "Sports")
    };

    public static readonly List<Product> Products = new()
    {
        new Product(1, "Laptop",           1, 1200m),
        new Product(2, "Headphones",       1,  150m),
        new Product(3, "Novel",            2,   20m),
        new Product(4, "Programming Book", 2,   45m),
        new Product(5, "Desk Lamp",        3,   35m),
        new Product(6, "Coffee Maker",     3,   80m),
        new Product(7, "Football",         4,   25m),
        new Product(8, "Yoga Mat",         4,   30m)
    };

    // Customer 6 (Nour) has no sales on purpose: used later for
    // "customers who never made a purchase".
    public static readonly List<Customer> Customers = new()
    {
        new Customer(1, "Ahmed",   "ahmed@example.com"),
        new Customer(2, "Sara",    "sara@example.com"),
        new Customer(3, "Omar",    "omar@example.com"),
        new Customer(4, "Laila",   "laila@example.com"),
        new Customer(5, "Youssef", "youssef@example.com"),
        new Customer(6, "Nour",    "nour@example.com")
    };

    // Dates span 2025 and 2026 so grouping by year works later.
    public static readonly List<Sale> Sales = new()
    {
        new Sale( 1, 1, 1, 1, new DateTime(2025, 11,  3)),
        new Sale( 2, 1, 3, 2, new DateTime(2025, 12, 15)),
        new Sale( 3, 2, 2, 1, new DateTime(2025, 12, 20)),
        new Sale( 4, 3, 4, 3, new DateTime(2026,  1, 10)),
        new Sale( 5, 2, 6, 1, new DateTime(2026,  1, 22)),
        new Sale( 6, 4, 7, 4, new DateTime(2026,  2,  5)),
        new Sale( 7, 1, 2, 2, new DateTime(2026,  2, 14)),
        new Sale( 8, 5, 5, 2, new DateTime(2026,  3,  1)),
        new Sale( 9, 3, 1, 1, new DateTime(2026,  3, 18)),
        new Sale(10, 4, 8, 3, new DateTime(2026,  4,  2)),
        new Sale(11, 2, 3, 5, new DateTime(2026,  4, 25)),
        new Sale(12, 5, 4, 1, new DateTime(2026,  5,  9)),
        new Sale(13, 3, 6, 2, new DateTime(2026,  6, 30)),
        new Sale(14, 1, 7, 1, new DateTime(2026,  8, 12)),
        new Sale(15, 4, 2, 1, new DateTime(2026, 10, 21))
    };
}