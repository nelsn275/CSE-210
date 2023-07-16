public class Order{
    Customer customer;
    List<Product> products = new List<Product>();


public Order(Customer _customer)
{
    customer = _customer;
}

public void AddItem(Product item)
{
    products.Add(item);
}
    public double Cost()
    {
        int shippingCost = 5;
        double total = 0;

        foreach (Product product in products)
        {
            total += product.GetPrice();
        }

        if (customer.LivesInUSA() == false)
        {
            shippingCost = 35;
        }

        total += shippingCost;
        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"{customer.GetName()} Packing Label:");
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetProductName()} ID: {product.GetProductID()} Amount: {product.GetProductQuantity()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{customer.GetName()} Packing Label:");
        customer.DisplayAddress();
    }
}