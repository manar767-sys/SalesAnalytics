using System;
using System.Collections.Generic;
using System.Linq;
using SalesAnalytics.App.Data;

namespace SalesAnalytics.App.Practice;
public record CustomerSummary(string Name, string Email);

internal static class Day31
{
    public static void Run()
    {
        // SelectMany vs Select
        var orders = new List<List<string>>
        {
            new() { "Laptop", "Mouse" },
            new() { "Book" },
            new() { "Lamp", "Mat", "Ball" }
        };

        IEnumerable<List<string>> nested = orders.Select(o => o);   // still nested
        IEnumerable<string> flattened = orders.SelectMany(o => o);  // flattened

        // Select: customer names
        IEnumerable<string> names = SampleData.Customers
            .Select(c => c.Name);

        // Select: anonymous type { CustomerName, CustomerId }
        var nameAndId = SampleData.Customers
            .Select(c => new { CustomerName = c.Name, CustomerId = c.Id });

        // Select: project into the CustomerSummary record
        IEnumerable<CustomerSummary> customerSummaries = SampleData.Customers
            .Select(c => new CustomerSummary(c.Name, c.Email));

        //view nested list 
        foreach (var laptoplist in nested)
        {
            foreach(var lap in laptoplist)
            {
                Console.WriteLine(lap);
            }
        }
        //view flattened list
        Console.WriteLine(string.Join(", ", flattened));
        Console.WriteLine($"count of nested lists is : {nested.Count()}");
    }
}