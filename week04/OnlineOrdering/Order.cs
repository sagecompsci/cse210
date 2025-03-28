public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string name, string street, string city, string country)
    {
        _customer = new Customer(name, street, city, country);
        _products = new List<Product>();
    }

    public void AddProduct(string name, int id, float price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public string Cost()
    {
        float sum = 0;
        foreach (Product item in _products)
        {
            sum += item.Cost();
        }

        if (_customer.InUnitedStates())
        {
            sum += 5;
        }
        else
        {
            sum += 35;
        }

        return sum.ToString("0.00");
    }

    public string PackingLabel()
    {
        List<string> products = new List<string>();
        foreach (Product item in _products)
        {
            products.Add(item.Label());
        }

        return String.Join("\n", products);
    }

    public string ShippingLabel()
    {
        return _customer.Label();
    }

    public void Display()
    {
        Console.WriteLine(ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(PackingLabel());
        Console.WriteLine($"Total Cost: {Cost()}");
        Console.WriteLine("");
    }
}