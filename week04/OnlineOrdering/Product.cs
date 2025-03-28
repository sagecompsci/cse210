public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public float Cost()
    {
        return _price * _quantity;
    }

    public string Label()
    {
        return $"{_name} - {_id}";
    }
}