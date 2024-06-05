using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.AddProduct("Bananas");
        order.AddProduct("Apples");
        Console.WriteLine("Customer Name: " + order.OrderList("John Smith"));
        Console.WriteLine("Total Price: " + order.OrderPrice(5, "USA"));
        Console.WriteLine("Packing Label: " + order.PackingLabel("Bananas", 1, 5, 2));
        Console.WriteLine("Shipping Label: " + order.ShippingLabel("John Smith", "123 Main Street", "Anytown", "CA", "USA"));
    }
}