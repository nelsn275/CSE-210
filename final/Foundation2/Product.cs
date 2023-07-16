public class Product{
    string name;
    int productId, quantity;
    double unitPrice;

    public Product(string _name, int _productId, double _unitPrice, int _quantity)
    {
        name = _name;
        productId = _productId;
        unitPrice = _unitPrice;
        quantity = _quantity;
    }
    public int GetProductID()
    {
        return productId;
    }

    public string GetProductName()
    {
        return name;
    }

    public int GetProductQuantity()
    {
        return quantity;
    }
    public double GetPrice()
    {
        double price = unitPrice * quantity;
        return price;
    }
}