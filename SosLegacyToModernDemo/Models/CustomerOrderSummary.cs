namespace SosLegacyToModernDemo.Models;

public class CustomerOrderSummary
{
    public long CustomerId { get; set; } // or it can be Guid
    public string FullName { get; set; } = string.Empty;
    public long TotalSpent { get; set; }
    public int OrderCount { get; set; }
}
