using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class Dessert : Dish
    {
        public abstract Dessert AddPresentationAttribute();

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(CustomDescription))
                return $"{DessertTexts.Label}\n{Order}.";
            return $"{DessertTexts.Label}\n{Order} .\nDescription : {CustomDescription}";            
        }
    }
}
