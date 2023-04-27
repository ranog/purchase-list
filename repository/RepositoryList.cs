using Model;

namespace Repository;

public static class RepositoryList{
    private static List<ShoppingList> _shoppingLists = new List<ShoppingList>();

    public static void Add(ShoppingList shoppingList){
        _shoppingLists.Add(shoppingList);
    }

    public static List<ShoppingList> GetAll(){
        return _shoppingLists;
    }
}
