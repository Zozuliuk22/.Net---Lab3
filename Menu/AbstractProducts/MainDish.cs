using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class MainDish : Dish
    {
        public abstract MainDish AddGlassOfWater();

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(CustomDescription))
                return $"{MainDishTexts.Label} {Order}.";
            return $"{MainDishTexts.Label} {Order}.\n\tDescription : {CustomDescription}";
        }
    }
}
