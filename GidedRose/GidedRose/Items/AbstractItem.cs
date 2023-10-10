namespace Kata.GidedRose.Items;

public abstract class AbstractItem : IItem
{
    protected int SellIn { get; set; }
    protected int Quality { get; set; }
    public string Name { get; }

    public AbstractItem(int sellIn, int quality, string name)
    {
        SellIn = sellIn;
        Quality = quality;
        Name = name;
    }


    public override string ToString()
    {
        return $"Name : {Name}, {nameof(SellIn)} : {SellIn}, {nameof(Quality)} : {Quality}";
    }

    public abstract void UpdateQuality();
}