using SosLegacyToModernDemo.Models;

namespace SosLegacyToModernDemo.Data;

public static class InMemoryData
{
    public static List<Customer> Customers { get; } = new()
    {
        new Customer { Id = 1, FullName = "Nafiseh Daneshian" },
        new Customer { Id = 2, FullName = "Ali Ghazi" },
        new Customer { Id = 3, FullName = "Farideh Jahani" }
    };

    public static List<Order> Orders { get; } = new()
    {
        new Order { Id = 1, CustomerId = 1, OrderDate = new DateTime(2025, 1, 5), TotalAmount = 1200 },
        new Order { Id = 2, CustomerId = 1, OrderDate = new DateTime(2025, 2, 10), TotalAmount = 800 },
        new Order { Id = 3, CustomerId = 2, OrderDate = new DateTime(2025, 3, 2), TotalAmount = 2500 },
        new Order { Id = 4, CustomerId = 3, OrderDate = new DateTime(2025, 4, 15), TotalAmount = 500 }
    };
}
