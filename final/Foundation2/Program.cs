using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Lenin St", "Moscow", "MO", "Russia");

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Irina Evsikova", address2);

        Product product1 = new Product("Laptop", "P1001", 999.99, 1);
        Product product2 = new Product("Mouse", "P1002", 19.99, 1);
        Product product3 = new Product("Keyboard", "P1003", 49.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}