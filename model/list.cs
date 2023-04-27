namespace Model;

public class List
{
    public readonly string Name;
    public DateTime DesiredDateOfPurchase { get; private set; }

    public List(string name, DateTime desiredDateOfPurchase)
    {
        Name = name;
        DesiredDateOfPurchase = desiredDateOfPurchase;
    }
}
