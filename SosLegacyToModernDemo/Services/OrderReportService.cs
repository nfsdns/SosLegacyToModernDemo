using SosLegacyToModernDemo.Data;
using SosLegacyToModernDemo.Models;

namespace SosLegacyToModernDemo.Services;

//public class OrderReportService : IOrderReportService
//{
//    public List<CustomerOrderSummary> GetTopCustomerOrders(DateTime startDate, DateTime endDate, long minAmount)
//    {
//        var customers = InMemoryData.Customers; // it can be a table in DB
//        var orders = InMemoryData.Orders; // it can be a table in DB

//        var query =
//            from c in customers
//            join o in orders on c.Id equals o.CustomerId
//            where o.OrderDate >= startDate && o.OrderDate <= endDate
//            group o by new { c.Id, c.FullName } into g
//            let totalSpent = g.Sum(o => o.TotalAmount)
//            where totalSpent >= minAmount
//            orderby totalSpent descending
//            select new CustomerOrderSummary
//            {
//                CustomerId = g.Key.Id,
//                FullName = g.Key.FullName,
//                TotalSpent = totalSpent,
//                OrderCount = g.Count()
//            };

//        return query.ToList();
//    }
//}


// if we have DBContext :

public class OrderReportService : IOrderReportService
{
    private readonly InMemoryContext _context;

    public OrderReportService()
    {
        _context = new InMemoryContext(); // If there is no DI
    }

    public List<CustomerOrderSummaryDto> GetTopCustomerOrders(
        DateTime startDate,
        DateTime endDate,
        long minAmount)
    {
        var query =
            from c in _context.Customers
            join o in _context.Orders on c.Id equals o.CustomerId
            where o.OrderDate >= startDate && o.OrderDate <= endDate
            group o by new { c.Id, c.FullName } into g
            let totalSpent = g.Sum(o => o.TotalAmount)
            where totalSpent >= minAmount
            orderby totalSpent descending
            select new CustomerOrderSummaryDto
            {
                CustomerId = g.Key.Id,
                FullName = g.Key.FullName,
                TotalSpent = totalSpent,
                OrderCount = g.Count()
            };

        return query.ToList();
    }
}