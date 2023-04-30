namespace Model;

public enum ProductCategory
{
    Marketplace = 1,
    Office,
    Maintenance,
}

public class Product : BaseModel
{
    public string Name { get; private set; } = default!;
    public ProductCategory ProductCategory { get; private set; }
    public decimal AmountPaid { get; private set; }
	public bool Bought { get; private set; }

    public Product(string name, ProductCategory productCategory)
    {
        AddValidation(string.IsNullOrEmpty(name), "Invalid name.");
        AddValidation(!ProductCategory.IsDefined(productCategory), "Invalid product category.");

        Name = name;
        ProductCategory = productCategory;
    }

    public void InformAmountPaid(decimal amountPaid)
    {
        AmountPaid = amountPaid;
        Bought = true;
    }
}
