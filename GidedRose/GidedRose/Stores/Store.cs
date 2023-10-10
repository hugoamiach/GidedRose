using System.Runtime.CompilerServices;
using Kata.GidedRose.Items;

namespace Kata.GidedRose.Stores;

public sealed class Store : IStore
{
    private readonly IItemFactory _itemFactory;

    public Store(IItemFactory itemFactory) => _itemFactory = itemFactory;

    private readonly IList<IItem> _items = new List<IItem>();

    public void AddItem(string name, int sellIn, int quality)
    {
        _items.Add(_itemFactory.CreateItem(name, sellIn, quality));
    }

    public void AddItem(SpecificItem itemType, int sellIn, int quality)
    {
        _items.Add(_itemFactory.CreateItem(itemType, sellIn, quality));
    }

    public void UpdateQualityItems()
    {
        foreach (var item in _items)
        {
            item.UpdateQuality();
        }
    }

    public IList<IItem> GetItem()
    {
        return _items;
    }
}