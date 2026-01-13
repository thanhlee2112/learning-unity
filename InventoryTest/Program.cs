using System;
using System.Threading;
public class Program
{
    static void Main()
    {
        Inventory inv = new Inventory(3);
        ItemData potion = new ItemData(1, "Potion", ItemType.Consumable, 5);

        inv.AddItem(potion, 1);
        inv.AddItem(potion, 1);
        inv.AddItem(potion, 5);

        foreach (var slot in inv.Slots)
        {
            if (!slot.isEmpty)
                Console.WriteLine($"{slot.Item.Name} x{slot.Quantity}");
        }
    }
}

