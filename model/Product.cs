namespace Model;

public enum ProductCategory
{
    Marketplace,
    Office,
    Maintenance,
}

public class Product
{
    public string Name { get; private set; } = default!;
    public ProductCategory ProductCategory { get; private set; }
    public decimal AmountPaid { get; private set; }
	public bool Bought { get; private set; }

    public Product(string name, ProductCategory productCategory)
    {
        Name = name;
        ProductCategory = productCategory;
    }

    public void InformAmountPaid(decimal amountPaid)
    {
        AmountPaid = amountPaid;
        Bought = true;
    }
}
