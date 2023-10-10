namespace Kata.GidedRose.Items;

public class SulfurasItem : AbstractItem
{
    private const string ItemName = "Sulfuras, Hand of Ragnaros";


    public SulfurasItem(int sellIn, int quality) : base(sellIn, quality, ItemName)
    {
    }

    public override void UpdateQuality()
    {
    }
}