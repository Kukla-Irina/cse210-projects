class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

   public double CalculateTotalCost()
{
    double totalCost = 0;

    foreach (Product product in _products)
    {
        totalCost += product.CalculateTotalCost();
    }

    if (_customer.IsInUSA())
    {
        totalCost += 5; 
    }
    else
    {
        totalCost += 35; 
    }

    return totalCost;
}

    public void GetPackingLabel()
    {
        Console.WriteLine($"Packaging Label for {_customer.GetName()}:");
        int counter = 1;
        foreach (Product product in _products)
        {
            Console.WriteLine($"{counter}. {product.GetName()} (ID: {product.GetProductId()}) - Price p/unit: ${product.GetPricePerUnit()} - Quantity: {product.GetQuantity()}");
            counter++;
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Shipping Label: {_customer.GetName()} - {_customer.GetAddress().GetFullAddress()}");
    }
}