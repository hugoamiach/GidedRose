using Kata.GidedRose.Items;

namespace Kata.GidedRose.Stores;

public sealed class ItemFactory : IItemFactory
{
    public IItem CreateItem(string name, int sellIn, int quality)
    {
        return name switch
        {
            "Aged Brie" => CreateItem(SpecificItem.AgedBrie, sellIn, quality),
            "Backstage passes to a TAFKAL80ETC concert" => CreateItem(SpecificItem.BackstagePasses, sellIn,
                quality),
            "Sulfuras, Hand of Ragnaros" => CreateItem(SpecificItem.Sulfura, sellIn, quality),
            _ => new ItemStandard(name, sellIn, quality)
        };
    }

    public IItem CreateItem(SpecificItem specificItem, int sellIn, int Quality)
    {
        return specificItem switch
        {
            SpecificItem.Sulfura => new SulfurasItem(sellIn, Quality),
            SpecificItem.BackstagePasses => new BackstageItem(sellIn, Quality),
            SpecificItem.AgedBrie => new AgedBrieItem(sellIn, Quality),
            _ => throw new ArgumentOutOfRangeException(nameof(specificItem), specificItem, "Invalid SpecificItem")
        };
    }
}