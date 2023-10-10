namespace Kata.GidedRose.Items;

public sealed class ItemStandard : AbstractItem
{
    public ItemStandard(string name, int sellIn, int quality) : base(sellIn, quality, name)
    {
    }


    public override void UpdateQuality()
    {
        DecrementQuality();
        DecrementSellIn();
        if (SellIn < 0)
            DecrementQuality();
    }

    private void DecrementQuality()
    {
        if (Quality > 0)
            Quality--;
    }

    private void DecrementSellIn()
    {
        SellIn--;
    }
}