using Menu.AbstractProducts;
using Menu.Properties;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.Beverages
{
    public class BeverageSupper : Beverage
    {
        public override Beverage AddGlassLabel()
        {
            Additions.Add("Glass with " + BeverageTexts.SupperGlassLabel + " label");
            return this;
        }

        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category == Categories.Drinks ||
                                      i.Category == Categories.Alcohol)
                          .ToList();
        }
    }
}
