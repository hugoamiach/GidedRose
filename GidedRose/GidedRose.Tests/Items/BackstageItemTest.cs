using FluentAssertions;
using Kata.GidedRose.Items;

namespace GidedRose.Tests.Items;

public class BackstageItemTest
{
    [Theory]
    [InlineData(2, 50, 50)]
    [InlineData(11, 48, 49)]
    [InlineData(10, 47, 49)]
    [InlineData(5, 47, 50)]
    [InlineData(0, 49, 0)]
    public void Test_UpdateQuality_When_SellInLessHas11_ShouldIncrementQuality(int sellIn, int quality,
        int shouldQuality)
    {
        var item = new BackstageItem(sellIn, quality);
        item.UpdateQuality();
        item.ToString().Should()
            .Be($"Name : Backstage passes to a TAFKAL80ETC concert, SellIn : {sellIn - 1}, Quality : {shouldQuality}");
    }
}