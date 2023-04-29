namespace Model;

public class ShoppingList
{
    public readonly string Name;
    public DateTime DesiredDateOfPurchase { get; private set; }
    public List<Product> Products { get; private set; } = new List<Product>();

    public ShoppingList(string name, DateTime desiredDateOfPurchase)
    {
        Name = name;
        DesiredDateOfPurchase = desiredDateOfPurchase;
    }

    public void AddProduct(Product product){
        Products.Add(product);
    }
}
