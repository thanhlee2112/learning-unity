public class InventorySlot
{
    public ItemData? Item {  get; private set; }
    public int Quantity { get; private set; }
    public bool isEmpty => Item == null;
    public bool canStack(ItemData item)
    {
        return item != null && Item != null && Item.Id == item.Id &&
            Quantity < Item.maxStack;
    }
    public void Add (ItemData item, int amount)
    {
        Item = item;
        Quantity += amount;
    }
    public void Clear()
    {
        Item = null;
        Quantity = 0;
    }
}