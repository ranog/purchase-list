using Repository;

namespace Cmd;

public static class OperationEditProduct{
    public static void Execute(){
        Console.WriteLine("Enter the name of the list: ");
        var desiredListName = Console.ReadLine();
        var lists = RepositoryList.GetAll();
        var wishList = lists.FirstOrDefault(l => l.Name == desiredListName);
        if(wishList == null){
            Console.WriteLine($"'{desiredListName}' list not found.");
            OperationEditList.Execute();
        }
        Console.WriteLine("Product name: ");
        var productName = Console.ReadLine();
        var desiredProduct = wishList.Products.FirstOrDefault(p => p.Name == productName);
        if(desiredProduct == null){
            Console.WriteLine($"'{productName}' product not found.");
            OperationEditList.Execute();
        }
        Console.WriteLine("Amount paid: ");
        var amountPaid = Console.ReadLine();
        desiredProduct.InformAmountPaid(decimal.Parse(amountPaid));
    }
}
