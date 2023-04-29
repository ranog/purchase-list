using EnumExtensions;
using Model;
using Repository;

InitialOperation();

void InitialOperation()
{
    while (true)
    {
        Console.WriteLine("Enter the desired operation:");
        Console.WriteLine($"{(int)ListOption.CreateList} - {ListOption.CreateList.GetDescription()}");
        Console.WriteLine($"{(int)ListOption.EditList} - {ListOption.EditList.GetDescription()}");
        Console.WriteLine($"{(int)ListOption.GetLists} - {ListOption.GetLists.GetDescription()}");
        var desiredOperation = Console.ReadLine();
        if (desiredOperation == $"{(int)ListOption.CreateList}")
            OperationCreateList();
        else if(desiredOperation == $"{(int)ListOption.EditList}")
        {
            OperationEditList();
        }
        else if(desiredOperation == $"{(int)ListOption.GetLists}"){
            OperationGetLists();
        }
    }
}

void OperationCreateList()
{
    Console.WriteLine("Name: ");
    var name = Console.ReadLine();
    Console.WriteLine("Desired date: ");
    var desiredDate = Console.ReadLine();
    var convertedDesiredDate = DateTime.Parse(desiredDate);
    var shoppingList = new ShoppingList(name, convertedDesiredDate);
    RepositoryList.Add(shoppingList);
    Console.WriteLine($"{shoppingList.Name} list created for {shoppingList.DesiredDateOfPurchase} date.");
    InitialOperation();
}

void OperationEditList()
{
    while (true)
    {
        Console.WriteLine("Enter the desired operation:");
        Console.WriteLine($"{(int)ProductOption.AddProduct} - {ProductOption.AddProduct.GetDescription()}");
        Console.WriteLine($"{(int)ProductOption.EditProduct} - {ProductOption.EditProduct.GetDescription()}");
        var desiredOperation = Console.ReadLine();
        if(desiredOperation == $"{(int)ProductOption.AddProduct}")
            OperationAddProduct();
        InitialOperation();
    }
}

void OperationAddProduct(){
    Console.WriteLine("Enter the name of the list: ");
    var desiredListName = Console.ReadLine();
    var lists = RepositoryList.GetAll();
    var wishList = lists.FirstOrDefault(l => l.Name == desiredListName);
    if(wishList == null){
        Console.WriteLine($"'{desiredListName}' list not found.");
        OperationEditList();
    }
    Console.WriteLine("Product name: ");
    var productName = Console.ReadLine();
    Console.WriteLine($"Product category ({(int)ProductCategory.Marketplace} - {ProductCategory.Marketplace}, {(int)ProductCategory.Office} - {ProductCategory.Office}, {(int)ProductCategory.Maintenance} - {ProductCategory.Maintenance}): ");
    var consoleProductCategory = Console.ReadLine();
    var productCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), consoleProductCategory);
    var product = new Product(name: productName, productCategory: productCategory);
    wishList.AddProduct(product);
}

void OperationGetLists()
{
    var lists = RepositoryList.GetAll();
    foreach(var item in lists){
        Console.WriteLine($"'{item.Name}' list created for date {item.DesiredDateOfPurchase} with {item.Products.Count()} product(s).");
    }
    InitialOperation();
}
