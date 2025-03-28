public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string country)
    {
        _name = name;
        _address = new Address(street, city, country);
    }

    public bool InUnitedStates()
    {
        return _address.InUnitedStates();
    }

    public string Label()
    {
        return $"{_name}\n{_address.ReturnAddress()}";
    }
}