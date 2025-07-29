using System;

class Program
{
    static void Main(string[] args)
    {
        // First order - USA customer
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LTP189", 800, 1));
        order1.AddProduct(new Product("Mouse", "MSE496", 25, 2));

        // Second order - international customer
        Address address2 = new Address("456 Banana Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emma Brown", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "TAB709", 300, 1));
        order2.AddProduct(new Product("Stylus", "STY176", 45, 1));
        order2.AddProduct(new Product("Keyboard", "KEY252", 70, 1));

        // Display for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        // Display for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
