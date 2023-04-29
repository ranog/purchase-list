using Model;
using Repository;

namespace Cmd;

public static class OperationCreateList{
    public static void Execute(){
        Console.WriteLine("Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Desired date: ");
        var desiredDate = Console.ReadLine();
        var convertedDesiredDate = DateTime.Parse(desiredDate);
        var shoppingList = new ShoppingList(name, convertedDesiredDate);
        RepositoryList.Add(shoppingList);
        Console.WriteLine($"{shoppingList.Name} list created for {shoppingList.DesiredDateOfPurchase} date.");
        InitialOperation.Execute();
    }
}
