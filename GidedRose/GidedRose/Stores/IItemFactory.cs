using Kata.GidedRose.Items;

namespace Kata.GidedRose.Stores;

public interface IItemFactory
{
    IItem CreateItem(string name, int sellIn, int quality);
    IItem CreateItem(SpecificItem specificItem, int sellIn, int Quality);
}