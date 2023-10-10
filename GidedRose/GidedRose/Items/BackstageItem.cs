namespace Kata.GidedRose.Items;

public sealed class BackstageItem : AbstractItem
{
    private const string ItemName = "Backstage passes to a TAFKAL80ETC concert";

    public BackstageItem(int sellIn, int quality) : base(sellIn, quality, ItemName)
    {
    }

    public override void UpdateQuality()
    {
        IncrementQuality();

        if (SellIn < 11)
        {
            IncrementQuality();
        }

        if (SellIn < 6)
        {
            IncrementQuality();
        }

        DecrementSellIn();
        if (SellIn < 0)
        {
            Quality = 0;
        }
    }

    private void IncrementQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    private void DecrementSellIn()
    {
        SellIn--;
    }
}