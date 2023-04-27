namespace Model;

public class ShoppingList
{
    public readonly string Name;
    public DateTime DesiredDateOfPurchase { get; private set; }

    public ShoppingList(string name, DateTime desiredDateOfPurchase)
    {
        Name = name;
        DesiredDateOfPurchase = desiredDateOfPurchase;
    }
}
