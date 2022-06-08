using Menu.AbstractProducts;
using Menu.Properties;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.MainDishes
{
    public class MainDishSupper : MainDish
    {
        public override MainDish AddGlassOfWater()
        {
            Additions.Add(MainDishTexts.WaterSupper);
            return this;
        }

        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category != Categories.Sweets ||
                                      i.Category != Categories.Drinks)
                          .ToList();
        }
    }
}
