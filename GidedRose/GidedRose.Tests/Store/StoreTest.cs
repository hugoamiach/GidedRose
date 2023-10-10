using FluentAssertions;
using Kata.GidedRose.Items;
using Moq;

namespace GidedRose.Tests.Store;

using Kata.GidedRose.Stores;

public class StoreTest
{
    private readonly Store _store;
    private readonly Mock<IItemFactory> _itemFactoryMock;

    public StoreTest()
    {
        _itemFactoryMock = new Mock<IItemFactory>();
        _store = new Store(_itemFactoryMock.Object);
    }

    [Fact]
    public void Test_AddItemByName()
    {
        _itemFactoryMock
            .Setup(m => m.CreateItem(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
            .Verifiable();
        _store.AddItem("foo", 0, 0);
        _itemFactoryMock.Verify(m => m.CreateItem("foo", 0, 0), Times.Once);
    }

    [Fact]
    public void Test_AddItemByType()
    {
        _store.AddItem(SpecificItem.AgedBrie, 0, 0);
        _itemFactoryMock.Verify(m => m.CreateItem(SpecificItem.AgedBrie, 0, 0), Times.Once);
    }

    [Fact]
    public void Test_UpdateQualityItems()
    {
        var itemMock = new Mock<IItem>();
        _itemFactoryMock
            .Setup(m => m.CreateItem(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
            .Returns(itemMock.Object)
            .Verifiable();
        itemMock
            .Setup(m => m.UpdateQuality())
            .Verifiable();

        _store.AddItem("foo", 0, 0);
        _store.UpdateQualityItems();
        _itemFactoryMock
            .Verify(m => m.CreateItem(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        itemMock.Verify(m => m.UpdateQuality(), Times.Once);
    }
}