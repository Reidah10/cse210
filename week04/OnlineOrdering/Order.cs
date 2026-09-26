public class Order
{
    public Customer Customer {get; set;}
    public List<Product> Products {get; set;}

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in Products)
        {
            total += product.Price * product.Quantity;
        }
        total += CalculateShippingCost();
        return total;
    }

    public double CalculateShippingCost()
    {
        if (Customer.IsInUSA())
        {
            return 5;
        }
        return 35;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in Products)
        {
            label += $"Product {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Ship to:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}