using Menu.AbstractProducts;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Menu.Products.Appetizers
{
    public class AppetizerBreakfast : Appetizer
    {
        public override List<Ingredient> GetIngredients()
        {
            var service = new StorageService();

            return service.GetAllIngredients()
                          .Where(i => i.Category == Categories.Vegetables)
                          .ToList();
        }
    }
}
