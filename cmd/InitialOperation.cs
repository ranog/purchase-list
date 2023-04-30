using EnumExtensions;

namespace Cmd;

public static class InitialOperation{
    public static void Execute(){
        while (true)
        {
            Console.WriteLine("Enter the desired operation:");
            Console.WriteLine($"{(int)ListOption.CreateList} - {ListOption.CreateList.GetDescription()}");
            Console.WriteLine($"{(int)ListOption.EditList} - {ListOption.EditList.GetDescription()}");
            Console.WriteLine($"{(int)ListOption.GetLists} - {ListOption.GetLists.GetDescription()}");
            Console.WriteLine($"{(int)ListOption.Report} - {ListOption.Report.GetDescription()}");
            var desiredOperation = Console.ReadLine();
            if (desiredOperation == $"{(int)ListOption.CreateList}")
                OperationCreateList.Execute();
            else if(desiredOperation == $"{(int)ListOption.EditList}")
            {
                OperationEditList.Execute();
            }
            else if(desiredOperation == $"{(int)ListOption.GetLists}"){
                OperationGetLists.Execute();
            }
            else if(desiredOperation == $"{(int)ListOption.Report}"){
                OperationReport.Execute();
            }
        }
    }
}
