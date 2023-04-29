using System.ComponentModel;

namespace EnumExtensions;

enum ProductOption
{
    [Description("Add product")]
    AddProduct = 1,

    [Description("Edit product")]
    EditProduct
}

enum ListOption
{
    [Description("Create List")]
    CreateList = 1,
    [Description("Edit List")]
    EditList,
    [Description("Get Lists")]
    GetLists,
}

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
        return attribute == null ? value.ToString() : attribute.Description;
    }
}
