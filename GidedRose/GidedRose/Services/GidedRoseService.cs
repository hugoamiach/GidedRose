using Kata.GidedRose.Stores;

namespace Kata.GidedRose.Services;

public class GidedRoseService
{
    private readonly IStore _store;

    public GidedRoseService(IStore store)
    {
        _store = store;
    }

    public void Run()
    {
        Console.WriteLine("OMGHAI!");

        _store.AddItem("+5 Dexterity Vest", 10, 20);
        _store.AddItem(SpecificItem.AgedBrie, 2, 0);
        _store.AddItem("Elixir of the Mongoose", 5, 7);
        _store.AddItem(SpecificItem.Sulfura, 0, 80);
        _store.AddItem(SpecificItem.Sulfura, -1, 80);
        _store.AddItem(SpecificItem.BackstagePasses, 15, 20);
        _store.AddItem(SpecificItem.BackstagePasses, 10, 49);
        _store.AddItem(SpecificItem.BackstagePasses, 5, 49);
        _store.AddItem("Conjured Mana Cake", 3, 6);

        for (var day = 0; day < 31; day++)
        {
            Console.WriteLine($"-------- day {day} --------");
            Console.WriteLine("name, sellIn, quality");

            foreach (var t in _store.GetItem())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("");
            _store.UpdateQualityItems();
        }
    }
}