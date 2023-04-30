using Model;
using Repository;

namespace Cmd;

public static class OperationCreateList{
    public static void Execute(){
        Console.WriteLine("Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Desired date: ");
        var desiredDate = Console.ReadLine();
        DateTime.TryParse(desiredDate, out var convertedDesiredDate);
        var shoppingList = new ShoppingList(name, convertedDesiredDate);
        if(!shoppingList.Valid()){
            foreach(var item in shoppingList.Errors)
                Console.WriteLine(item);
            InitialOperation.Execute();
        }
        RepositoryList.Add(shoppingList);
        Console.WriteLine($"{shoppingList.Name} list created for {shoppingList.DesiredDateOfPurchase} date.");
        InitialOperation.Execute();
    }
}
