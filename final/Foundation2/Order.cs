public class Order
{
    private double _totalPrice = 0;
    private List<Product> _listOfProducts = new List<Product>();
    Customer _customer;
    public Order(string customerName, string streetAdress, string city, string state, string country)
    {
        _customer = new Customer(customerName, streetAdress, city, state, country);
    }

    public void AddProductToOrder(Product product)
    {
        _listOfProducts.Add(product);
    }

    public void PackingLabel()
    {
        Console.WriteLine("PACKING LABEL:");
        foreach (Product product in _listOfProducts)
        {
            Console.WriteLine($"{product.GetProductName()} - ID: {product.GetProductId()} - QTY: {product.GetQuantity()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine($"{_customer.GetCustomerName()}");
        Console.WriteLine(_customer.FullAdressString());
    }

    public double GetShippingPrice()
    {
        double shippingPrice;
        if (_customer.IsFromUSA())
        {
            shippingPrice = 5.00;
        }
        else
        {
            shippingPrice = 35.00;
        }
        return shippingPrice;
    }

    public double ComputeTotalPrice()
    {
        foreach (Product product in _listOfProducts)
        {
            _totalPrice += product.Subtotal();
        }
        _totalPrice += GetShippingPrice();
        return _totalPrice;
    }

    public void Display()
    {
        PackingLabel();
        Console.WriteLine();
        ShippingLabel();
        Console.WriteLine($"Shipping price   : ${GetShippingPrice()}");
        Console.WriteLine($"Total order price: ${ComputeTotalPrice()}");
    }
}