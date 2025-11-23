using SosLegacyToModernDemo.Models;

namespace SosLegacyToModernDemo.Data;

public class InMemoryContext
{
    private readonly List<Customer> _customers;
    private readonly List<Order> _orders;

    public IQueryable<Customer> Customers => _customers.AsQueryable();
    public IQueryable<Order> Orders => _orders.AsQueryable();

    public InMemoryContext()
    {
        _customers = SeedCustomers();
        _orders = SeedOrders();
    }

    private List<Customer> SeedCustomers()
    {
        return new List<Customer>
        {
            new Customer { Id = 1, FullName = "Nafiseh Daneshian" },
            new Customer { Id = 2, FullName = "Ali Ghazi" },
            new Customer { Id = 3, FullName = "Farideh Jahani" }
        };
    }

    private List<Order> SeedOrders()
    {
        return new List<Order>
        {
            new Order { Id = 1, CustomerId = 1, OrderDate = new DateTime(2024, 1, 5), TotalAmount = 1200 },
            new Order { Id = 2, CustomerId = 1, OrderDate = new DateTime(2024, 2, 10), TotalAmount = 800 },
            new Order { Id = 3, CustomerId = 2, OrderDate = new DateTime(2024, 3, 2), TotalAmount = 2500 },
            new Order { Id = 4, CustomerId = 3, OrderDate = new DateTime(2024, 4, 15), TotalAmount = 500 }
        };
    }
}
