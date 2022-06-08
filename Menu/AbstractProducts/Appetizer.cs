using Menu.Properties;

namespace Menu.AbstractProducts
{
    public abstract class Appetizer : Dish
    {
        public virtual Appetizer AddGloves()
        {
            Additions.Add(AppetizerTexts.GlovesMessage);
            return this;
        }

        public override string ToString()
        {
            if(string.IsNullOrWhiteSpace(CustomDescription))
                return $"{AppetizerTexts.Label}\n{Order}.";
            return $"{AppetizerTexts.Label}\n{Order}.\nDescription : {CustomDescription}";
        }
    }
}
