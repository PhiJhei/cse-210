using System.Numerics;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();


    public Order()
    {
        
    }
    public double TotalCost(double shippingFee)
    {
        foreach (var item in _products)
        {
            shippingFee += item.Total();
        }
        return shippingFee;
    }

    public void AddOrder(Product product)
    {
        _products.Add(product);
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (var item in _products)
        {
            label += item.GetProductName() + " " + item.GetProductID() + "\n";
        }
        return label;
    }
    public string ShippingLabel(string name, string address)
    {
        // customer name + address
        return $"{name} - {address}";
    }
}