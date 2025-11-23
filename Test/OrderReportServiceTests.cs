using SosLegacyToModernDemo.Services;
using Xunit;

namespace LegacyToModernDemo.Tests
{
    public class OrderReportServiceTests
    {
        private readonly OrderReportService _service;

        public OrderReportServiceTests()
        {
            _service = new OrderReportService(); // Without DI
        }

        [Fact]
        public void GetTopCustomerOrders_ShouldReturnCustomers_WithTotalSpentAboveMinAmount()
        {
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 12, 31);
            long minAmount = 1000;

            var result = _service.GetTopCustomerOrders(startDate, endDate, minAmount);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.All(result, x => Assert.True(x.TotalSpent >= minAmount)); // amount condition 
        }

        [Fact]
        public void GetTopCustomerOrders_ShouldReturnEmpty_WhenNoOrdersMeetCriteria()
        {
            var startDate = new DateTime(2025, 5, 1);
            var endDate = new DateTime(2025, 5, 31);
            long minAmount = 5000;

            var result = _service.GetTopCustomerOrders(startDate, endDate, minAmount);

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void GetTopCustomerOrders_ShouldOrderDescendingByTotalSpent()
        {
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 12, 31);
            long minAmount = 100;

            var result = _service.GetTopCustomerOrders(startDate, endDate, minAmount);

            Assert.True(result.SequenceEqual(result.OrderByDescending(x => x.TotalSpent)));
        }
    }
}
