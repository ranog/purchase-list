using Model;
using Repository;

namespace Cmd;

public static class OperationCreateList{
    public static void Execute(){
        Console.WriteLine("Name: ");
        var name = Console.ReadLine();
        if(string.IsNullOrEmpty(name)){
            Console.WriteLine("Invalid name.");
            InitialOperation.Execute();
        }
        Console.WriteLine("Desired date: ");
        var desiredDate = Console.ReadLine();
        if(!DateTime.TryParse(desiredDate, out var convertedDesiredDate)){
            Console.WriteLine("Invalid date.");
            InitialOperation.Execute();
        }
        var shoppingList = new ShoppingList(name, convertedDesiredDate);
        RepositoryList.Add(shoppingList);
        Console.WriteLine($"{shoppingList.Name} list created for {shoppingList.DesiredDateOfPurchase} date.");
        InitialOperation.Execute();
    }
}
