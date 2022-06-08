using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class Beverage : Dish
    {
        public abstract Beverage AddGlassLabel();

        public virtual Beverage AddIceCubes()
        {   
            Additions.Add(BeverageTexts.IceCubesMessage); 
            return this;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(CustomDescription))
                return $"{BeverageTexts.Label}\n{Order}.";
            return $"{BeverageTexts.Label}\n{Order}.\nDescription : {CustomDescription}";            
        }
    }
}
