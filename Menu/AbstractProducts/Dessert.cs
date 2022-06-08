using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class Dessert : Dish
    {
        public abstract Dessert AddPresentationAttribute();

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(CustomDescription))
                return $"{DessertTexts.Label} {Order}.";
            return $"{DessertTexts.Label} {Order}.\n\tDescription : {CustomDescription}";            
        }
    }
}
