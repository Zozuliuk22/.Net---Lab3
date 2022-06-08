using Menu.AbstractProducts;
using Menu.Properties;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.Desserts
{
    public class DessertBreakfast : Dessert
    {
        public override Dessert AddPresentationAttribute()
        {
            Additions.Add(DessertTexts.BreakfastAttribute);
            return this;
        }

        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category == Categories.Fruits ||
                                      i.Category == Categories.Sweets)
                          .ToList();
        }
    }
}
