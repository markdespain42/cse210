using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.AddProduct("Bananas");
        order.AddProduct("Apples");
        Console.WriteLine(order.OrderList("John Smith"));
        Console.WriteLine(order.OrderPrice(5));
        Console.WriteLine(order.PackingLabel("Bananas", 1, 5, 2));
        Console.WriteLine(order.ShippingLabel("John Smith", "123 Main Street", "Anytown", "CA", "USA"));
    }
}