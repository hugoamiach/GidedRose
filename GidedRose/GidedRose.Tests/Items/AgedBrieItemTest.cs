using FluentAssertions;
using Kata.GidedRose.Items;

namespace GidedRose.Tests.Items;

public class AgedBrieItemTest
{
    private AgedBrieItem _agedBrieItem;

    [Theory]
    [InlineData(50)]
    [InlineData(51)]
    public void Test_UpdateQuality_When_QualityEqualOrBetterThan50_Should_DecrementSellIn(int quality)
    {
        _agedBrieItem = new AgedBrieItem(1, quality);
        _agedBrieItem.UpdateQuality();
        _agedBrieItem.ToString().Should().Be($"Name : Aged Brie, SellIn : 0, Quality : {quality}");
    }

    [Fact]
    public void Test_UpdateQuality_When_QualityIsLessThan50_Should_IncrementQuality()
    {
        _agedBrieItem = new AgedBrieItem(1, 49);
        _agedBrieItem.UpdateQuality();
        _agedBrieItem.ToString().Should().Be($"Name : Aged Brie, SellIn : 0, Quality : 50");
    }

    [Fact]
    public void Test_UpdateQuality_When_SellInIsLessThan0_Should_IncrementQuality()
    {
        _agedBrieItem = new AgedBrieItem(-1, 48);
        _agedBrieItem.UpdateQuality();
        _agedBrieItem.ToString().Should().Be($"Name : Aged Brie, SellIn : -2, Quality : 50");
    }
}