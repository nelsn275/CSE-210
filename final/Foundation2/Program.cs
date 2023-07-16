using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new Customers

        
        // Create new Addresses
        Address addy1 = new Address("P Sherman, 42 Wallaby Way", "Sydney", "Western Australia", "Australia");
        Address addy2 = new Address("13 Main St", "New York", "New York", "USA");

        Customer Emma = new Customer("Emma Nelson", addy1);
        Customer Nick = new Customer("Nicholas Nelson", addy2);

        // Create Products
        Product shampoo = new Product("Shampoo", 43, 4.99, 1);
        Product MMs = new Product("M&M's", 109, 9.99, 12);
        Product boxFreezer = new Product("Box Freezer", 4, 199.99, 1);
        Product iphone = new Product("Iphone 23 Pro Max", 44, 1599.99, 1);
        Product peanuts = new Product("Peanuts", 200, 6.99, 2);

        // Create the 2 orders by assigning customers and products to each order
        Order emsOrder = new Order(Emma);
        Order nicksOrder = new Order(Nick);

        emsOrder.AddItem(shampoo);
        emsOrder.AddItem(MMs);
        emsOrder.AddItem(iphone);
        nicksOrder.AddItem(iphone);
        nicksOrder.AddItem(boxFreezer);
        nicksOrder.AddItem(peanuts);

        // Display the packing label, shipping labe, and total cost of the Order


        emsOrder.DisplayPackingLabel();
        emsOrder.DisplayShippingLabel();
        Console.WriteLine(emsOrder.Cost());

        Console.WriteLine();

        nicksOrder.DisplayPackingLabel();
        nicksOrder.DisplayShippingLabel();
        Console.WriteLine(nicksOrder.Cost());


    }
}