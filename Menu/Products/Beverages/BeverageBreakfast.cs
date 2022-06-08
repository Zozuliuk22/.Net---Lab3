using Menu.AbstractProducts;
using Menu.Properties;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.Beverages
{
    public class BeverageBreakfast : Beverage
    {
        public override Beverage AddGlassLabel()
        {
            Additions.Add("Glass with " + BeverageTexts.BreakfastGlassLabel + " label");
            return this;
        }

        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category == Categories.Drinks ||
                                      i.Category == Categories.Fruits ||
                                      i.Category == Categories.Vegetables ||
                                      i.Category == Categories.Spices)
                          .ToList();
        }
    }
}
