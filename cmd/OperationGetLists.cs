using Repository;

namespace Cmd;

public static class OperationGetLists{
    public static void Execute(){
        var lists = RepositoryList.GetAll();
        foreach(var item in lists){
            Console.WriteLine($"'{item.Name}' list created for date {item.DesiredDateOfPurchase} with {item.Products.Count()} product(s).");
            foreach(var product in item.Products)
                Console.WriteLine($"Product: '{product.Name}' - {product.ProductCategory} with value {product.AmountPaid}.");
        }
        InitialOperation.Execute();
    }
}
