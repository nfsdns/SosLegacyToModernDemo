using SosLegacyToModernDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosLegacyToModernDemo.Services;

public interface IOrderReportService
{
    List<CustomerOrderSummary> GetTopCustomerOrders(
       DateTime startDate,
       DateTime endDate,
       long minAmount);
}
