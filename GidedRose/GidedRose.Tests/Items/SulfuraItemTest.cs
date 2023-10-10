using FluentAssertions;
using Kata.GidedRose.Items;

namespace GidedRose.Tests.Items;

public class SulfuraItemTest
{
    [Fact]
    public void Test_UpdateQuality()
    {
        var item = new SulfurasItem(2, 50);
        item.UpdateQuality();
        item.ToString().Should().Be($"Name : Sulfuras, Hand of Ragnaros, SellIn : 2, Quality : 50");
    }
}