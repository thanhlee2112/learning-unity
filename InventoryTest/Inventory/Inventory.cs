using System.Collections.Generic;
public class Inventory
{
    public List<InventorySlot> slots;
    public IReadOnlyList<InventorySlot> Slots => slots;
    public Inventory(int size)
    {
        slots = new List<InventorySlot>(size);
        for (int i = 0; i < size; i++)
        {
            slots.Add(new InventorySlot());
        }
    }
    public bool AddItem(ItemData item, int amount)
    {
        int remaining = 0;
        foreach (var slot in slots)
        {
            if (slot.canStack(item))
            {
                if(amount + slot.Quantity <= item.maxStack)
                {
                    slot.Add(item, amount);
                    return true;
                }
                else
                {
                    remaining += amount - item.maxStack + slot.Quantity;
                    slot.Add(item, item.maxStack - slot.Quantity);
                    break;
                }
            }
        }
        foreach (var slot in slots)
        {
            if (slot.isEmpty)
            {
                if(remaining == 0)
                {
                    slot.Add(item, amount);
                    return true;
                }
                else
                {
                    slot.Add(item, remaining);
                    remaining -= item.maxStack;
                    if(remaining <= 0)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}