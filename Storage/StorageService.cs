using System.Collections.Generic;

namespace Storage
{
    public class StorageService
    {
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return DataContext.Ingredients;
        }
    }
}
