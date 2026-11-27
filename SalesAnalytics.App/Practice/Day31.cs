using System;
using System.Collections.Generic;
using System.Linq;
using SalesAnalytics.App.Data;

namespace SalesAnalytics.App.Practice
{
    public record CustomerSummary(string Name, string Email);

    internal class Day31
    {
        public static void Run() {
            //produce list of customer names
            IEnumerable<string> names = SampleData.Customers.Select(c => c.Name);

            //produce a list of new anynoumous data type has {name , id }
            var nameId = SampleData.Customers.Select(c =>
            new { CustomerName = c.Name, CustomerId = c.Id });

            //project into the new type/record made
            IEnumerable<CustomerSummary> customerSummaries = SampleData.Customers.Select( x => new CustomerSummary(x.Name,x.Email));


            foreach (var cs in customerSummaries)
            {
                Console.WriteLine($"custmer name is : {cs.Name} : {cs.Email}");

            
            }

        } 
    }
}
