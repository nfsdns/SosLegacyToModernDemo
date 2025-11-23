
using SosLegacyToModernDemo.Services;

var reportService = new OrderReportService();

var startDate = new DateTime(2024, 1, 1);
var endDate = new DateTime(2024, 12, 31);
long minAmount = 1000;

var summaries = reportService.GetTopCustomerOrders(startDate, endDate, minAmount);

Console.WriteLine("Top Customers Report");
Console.WriteLine("--------------------");

foreach (var item in summaries)
{
    Console.WriteLine(
        $"{item.FullName} | Total Spent: {item.TotalSpent} | Orders: {item.OrderCount}");
}

Console.WriteLine("\nDone.");
