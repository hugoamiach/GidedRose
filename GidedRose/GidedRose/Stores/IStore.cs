using Kata.GidedRose.Items;

namespace Kata.GidedRose.Stores;

public interface IStore
{
    void AddItem(string name, int sellIn, int quality);
    void AddItem(SpecificItem itemType, int sellIn, int quality);
    void UpdateQualityItems();
    IList<IItem> GetItem();
}