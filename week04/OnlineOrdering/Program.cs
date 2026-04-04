using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {

        // Non-US Citizen
        Address address = new("Purok Sibuyan A", "Cotabato", "Maguindanao", "PH");
        Customer customer = new("Juan Dela Cruz",address);
        double ShippingFee = customer.GetShippingFee(address.InStates());

        Order o1 = new();
        o1.AddOrder(new Product("Milk","1A",4.5,2));
        o1.AddOrder(new Product("Apple","1B",2.5,2));
        o1.AddOrder( new Product("Mango","2B",1.5,2));

        Console.WriteLine(o1.ShippingLabel(customer.GetName(),address.GetAddress()));
        Console.WriteLine(o1.PackingLabel());
        Console.Write("Total: ");
        Console.WriteLine(o1.TotalCost(ShippingFee));

        Console.WriteLine();
        // US Citizen
        Address address1 = new("Purok Sibuyan A", "Cotabato", "Maguindanao", "PH");
        Customer customer1 = new("Juan Dela Cruz",address);
        double ShippingFee1 = customer.GetShippingFee(address.InStates());

        Order o2 = new();
        o2.AddOrder(new Product("Bulb","1C",7,4));
        o2.AddOrder(new Product("Table","22B",399.9,1));
        o2.AddOrder( new Product("Cabinet","512B",259.9,2));

        Console.WriteLine(o2.ShippingLabel(customer1.GetName(),address1.GetAddress()));
        Console.WriteLine(o2.PackingLabel());
        Console.Write("Total: ");
        Console.WriteLine(o2.TotalCost(ShippingFee1));
    }
}