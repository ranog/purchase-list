using EnumExtensions;

namespace Cmd;

public static class OperationEditList{
    public static void Execute(){
        while (true)
        {
            Console.WriteLine("Enter the desired operation:");
            Console.WriteLine($"{(int)ProductOption.AddProduct} - {ProductOption.AddProduct.GetDescription()}");
            Console.WriteLine($"{(int)ProductOption.EditProduct} - {ProductOption.EditProduct.GetDescription()}");
            var desiredOperation = Console.ReadLine();
            if(desiredOperation == $"{(int)ProductOption.AddProduct}")
                OperationAddProduct.Execute();
            else if(desiredOperation == $"{(int)ProductOption.EditProduct}")
                OperationEditProduct.Execute();
            InitialOperation.Execute();
        }
    }
}
