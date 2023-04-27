using Model;
using Repository;

InitialOperation();

void InitialOperation()
{
    while (true)
    {
        Console.WriteLine("Enter the desired operation:");
        Console.WriteLine("1 - Create List");
        Console.WriteLine("2 - Edit List");
        Console.WriteLine("3 - Get Lists");
        var desiredOperation = Console.ReadLine();
        if (desiredOperation == "1")
            OperationCreateList();
        else if(desiredOperation == "2")
        {
            OperationEditList();
        }
        else if(desiredOperation == "3"){
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
        Console.WriteLine("1 - Add Items");
        Console.WriteLine("2 - Edit Items");
        var desiredOperation = Console.ReadLine();
        InitialOperation();
    }
}

void OperationGetLists()
{
    var lists = RepositoryList.GetAll();
    foreach(var item in lists){
        Console.WriteLine($"'{item.Name}' list created for {item.DesiredDateOfPurchase} date.");
    }
    InitialOperation();
}
