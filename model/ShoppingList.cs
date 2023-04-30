namespace Model;

public class ShoppingList : BasicModel
{
    public readonly string Name;
    public DateTime DesiredDateOfPurchase { get; private set; }
    public List<Product> Products { get; private set; } = new List<Product>();

    public ShoppingList(string name, DateTime desiredDateOfPurchase)
    {
        AddValidation(string.IsNullOrEmpty(name), "Invalid name.");
        AddValidation(desiredDateOfPurchase == DateTime.MinValue, "Invalid date.");

        Name = name;
        DesiredDateOfPurchase = desiredDateOfPurchase;
    }

    public void AddProduct(Product product){
        Products.Add(product);
    }
}
