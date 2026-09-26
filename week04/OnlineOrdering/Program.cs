using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "UT",
            "USA"
        );

        Customer customer1 = new Customer("Mac Davis", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Basket", 150, 12.99, 3);
        Product product2 = new Product("Whicker Chair",151, 24.99, 1);
        Product product3 = new Product("Step Stool", 152, 14.99, 1);

        order1.Products.Add(product1);
        order1.Products.Add(product2);
        order1.Products.Add(product3);

        Address address2 = new Address(
            "456 Side Street",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Sarah Sigzil", address2);

        Order order2 = new Order(customer2);

        Product product4 = new Product("Shelf",154, 19.99, 1);
        Product product5 = new Product("Rug", 149, 34.99, 2);
        Product product6 = new Product("Mirror", 153, 14.99, 4);

        order2.Products.Add(product4);
        order2.Products.Add(product5);
        order2.Products.Add(product6);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Order Cost: ${order.CalculateTotalCost():F2}");
            Console.WriteLine();
        }
    }
}