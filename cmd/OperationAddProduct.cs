using Model;
using Repository;

namespace Cmd;

public static class OperationAddProduct{
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
        Console.WriteLine($"Product category ({(int)ProductCategory.Marketplace} - {ProductCategory.Marketplace}, {(int)ProductCategory.Office} - {ProductCategory.Office}, {(int)ProductCategory.Maintenance} - {ProductCategory.Maintenance}): ");
        var consoleProductCategory = Console.ReadLine();
        Enum.TryParse<ProductCategory>(consoleProductCategory, out ProductCategory productCategory);
        var product = new Product(productName, productCategory);
        if(!product.Valid())
            foreach(var item in product.Errors)
                Console.WriteLine(item);
        else
            wishList.AddProduct(product);
    }
}
