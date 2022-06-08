using Menu.AbstractProducts;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.Appetizers
{
    public class AppetizerSupper : Appetizer
    {
        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category == Categories.Vegetables ||
                                      i.Category == Categories.Meat ||
                                      i.Category == Categories.Fish)
                          .ToList();
        }
    }
}
