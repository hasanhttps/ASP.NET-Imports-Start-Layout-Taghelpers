namespace ASP.NET_Data_Managment.Models;

public class Product {
    
    // Fields

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}