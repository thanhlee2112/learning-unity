public class ItemData
{
    public int Id;
    public string Name;
    public ItemType ItemType;
    public int maxStack;

    public ItemData(int Id, string name, ItemType type, int maxStack)
    {
        this.Id = Id;
        this.Name = name;
        this.ItemType = type;
        this.maxStack = maxStack;
    }
}