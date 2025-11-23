namespace SosLegacyToModernDemo.Models;
public class Order
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public long TotalAmount { get; set; }
}


