public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public void SetProductId(int productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
    public double Subtotal()
    {
        double subtotal = _price * _quantity;
        return subtotal;
    }
}