public class Product
{
    public string Name {get; set;}
    public int ProductId {get; set;}
    public double Price {get; set;}
    public int Quantity {get; set;}
    public Product(string name, int productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }
    
}
