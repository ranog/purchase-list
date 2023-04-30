using Repository;

namespace Cmd;

public static class OperationReport{
    public static void Execute(){
        Console.WriteLine("Enter the name of the list: ");
        var desiredListName = Console.ReadLine();
        var lists = RepositoryList.GetAll();
        var wishList = lists.FirstOrDefault(l => l.Name == desiredListName);
        if(wishList == null){
            Console.WriteLine($"'{desiredListName}' list not found.");
            InitialOperation.Execute();
        }
        var totalInReaisOfTheProducts = wishList.Products.Sum(p => p.AmountPaid);
        var totalInMarketplaceReais = wishList.Products
            .Where(p => p.ProductCategory == Model.ProductCategory.Marketplace).Sum(p => p.AmountPaid);
        var totalInOfficeReais = wishList.Products
            .Where(p => p.ProductCategory == Model.ProductCategory.Office).Sum(p => p.AmountPaid);
        var totalInMaintenanceReais = wishList.Products
            .Where(p => p.ProductCategory == Model.ProductCategory.Maintenance).Sum(p => p.AmountPaid);
        var totalNumberOfProductsNotPurchased = wishList.Products.Where(p => !p.Bought).Count();

        Console.WriteLine($"Total in reais {totalInReaisOfTheProducts}.");
        Console.WriteLine($"Total in marketplace {totalInMarketplaceReais}.");
        Console.WriteLine($"total in office {totalInOfficeReais}.");
        Console.WriteLine($"Total in maintenance {totalInMaintenanceReais}.");
        Console.WriteLine($"Total products not purchased {totalNumberOfProductsNotPurchased}.");
    }
}
