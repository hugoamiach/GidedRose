using FluentAssertions;
using Kata.GidedRose.Items;
using Kata.GidedRose.Stores;

namespace GidedRose.Tests.Store;

public class ItemFactoryTest
{
    [Theory]
    [InlineData("ItemName", typeof(ItemStandard))]
    [InlineData("Aged Brie", typeof(AgedBrieItem))]
    [InlineData("Backstage passes to a TAFKAL80ETC concert", typeof(BackstageItem))]
    [InlineData("Sulfuras, Hand of Ragnaros", typeof(SulfurasItem))]
    public void Test_CreateItem_Should_CreateItem(string itemName, Type shouldType)
    {
        var itemFactory = new ItemFactory();
        var item = itemFactory.CreateItem(itemName, 0, 0);
        item.Should().BeOfType(shouldType);
    }

    [Theory]
    [InlineData(SpecificItem.AgedBrie, typeof(AgedBrieItem))]
    [InlineData(SpecificItem.BackstagePasses, typeof(BackstageItem))]
    [InlineData(SpecificItem.Sulfura, typeof(SulfurasItem))]
    public void Test_CreateSpecificItem_Should_CreateItem(SpecificItem specificItem, Type shouldType)
    {
        var itemFactory = new ItemFactory();
        var item = itemFactory.CreateItem(specificItem, 0, 0);
        item.Should().BeOfType(shouldType);
    }

    [Fact]
    public void Test_CreateSpecificItem_Should_ThrowArgumentOutOfRangeException()
    {
        var itemFactory = new ItemFactory();
        var action = () => itemFactory.CreateItem((SpecificItem) 5, 0, 0);
        action.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Invalid SpecificItem (Parameter 'specificItem')\nActual value was 5.");
    }
}