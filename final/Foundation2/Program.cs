using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new("John Smith", address1);
        Order order1 = new(customer1);
        Product product1 = new("Laptop", "P1001", 999, 1); 
        Product product2 = new("Mouse", "P1002", 19, 3);
        Product product3 = new("Keyboard", "P1003", 49, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.GetShippingLabel();
        Console.WriteLine(); 
        order1.GetPackingLabel();
        Console.WriteLine(); 
        Console.WriteLine($"Total price: {order1.CalculateTotalCost()}$");
        Console.WriteLine(); 

        Address address2 = new("456 Lenin St", "Moscow", "MO", "Russia");
        Customer customer2 = new("Irina Evsikova", address2);
        Order order2 = new(customer2);
        Product product21 = new("Laptop", "P1001", 999, 4); 
        Product product22 = new("Mouse", "P1002", 19, 5);
        Product product23 = new("Keyboard", "P1003", 49, 2);

        order2.AddProduct(product21);
        order2.AddProduct(product22);
        order2.AddProduct(product23);

        order2.GetShippingLabel();
        Console.WriteLine(); 
        order2.GetPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total price: {order2.CalculateTotalCost()}$");
        Console.WriteLine(); 
    }

}