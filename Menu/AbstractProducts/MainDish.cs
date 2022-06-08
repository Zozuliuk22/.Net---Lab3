using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class MainDish : Dish
    {
        public abstract MainDish AddGlassOfWater();

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(CustomDescription))
                return $"{MainDishTexts.Label}\n{Order}.";
            return $"{MainDishTexts.Label}\n{Order} .\nDescription : {CustomDescription}";
        }
    }
}
