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
        try{
            var shoppingList = new ShoppingList(name, convertedDesiredDate);
            RepositoryList.Add(shoppingList);
            Console.WriteLine($"{shoppingList.Name} list created for {shoppingList.DesiredDateOfPurchase} date.");
        } catch(ArgumentException error){
            Console.WriteLine(error.Message);
        }
        InitialOperation.Execute();
    }
}
