using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        
        Order order1 = new Order("Tim Cognito", "123 Fake Avenue", "Fake City", "Canada");
        order1.AddProduct("Phone Charger", 12345, 10, 1);
        order1.AddProduct("Pillow", 203495, 20.59f, 3);
        
        orders.Add(order1);

        Order order2 = new Order("Pete Zapaya", "230497 Candy Road", "Chocolate City", "United States");
        order2.AddProduct("Rubiks Cube", 0987643, 15.15f, 1);
        order2.AddProduct("Hair Brush", 39856, 13.99f, 2);
        
        orders.Add(order2);

        foreach (Order item in orders)
        {
            item.Display();
        }
    }
}