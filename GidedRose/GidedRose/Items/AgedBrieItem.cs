namespace Kata.GidedRose.Items;

public sealed class AgedBrieItem : AbstractItem
{
    private const string ItemName = "Aged Brie";

    public AgedBrieItem(int sellIn, int quality) : base(sellIn, quality, ItemName)
    {
    }

    public override void UpdateQuality()
    {
        IncrementQuality();
        DecrementSellIn();
        if (SellIn < 0)
        {
            IncrementQuality();
        }
    }

    private void DecrementSellIn()
    {
        SellIn--;
    }

    private void IncrementQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }
}