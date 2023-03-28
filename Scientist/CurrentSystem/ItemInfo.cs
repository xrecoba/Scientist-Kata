namespace ScientistKata.CurrentSystem;

public class ItemInfo
{
    public string Name { get; set; }

    /// <summary>
    /// Amount of units of the item in stock
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// Max amount of units of the item we can store
    /// </summary>
    public int MaxStock { get; set; }

    /// <summary>
    /// How many units of this item were sold yesterday
    /// </summary>
    public int YesterdaysConsumption { get; set; }

    public ItemInfo(string name, int stock, int maxStock, int yesterdaysConsumption)
    {
        Name = name;
        Stock = stock;
        MaxStock = maxStock;
        YesterdaysConsumption = yesterdaysConsumption;
    }

    /// <summary>
    /// Unique identifier of an ItemInfo
    /// </summary>
    /// <returns>A number</returns>
    public int UniqueIdentifier()
    {
        return (Stock * MaxStock - YesterdaysConsumption ^ 2) + Name.ToCharArray().Sum(c => c);
    }
}