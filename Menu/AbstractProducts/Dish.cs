using Storage;
using System;
using System.Collections.Generic;

namespace Menu
{
    public abstract class Dish
    {
        public List<Ingredient> Ingredients { get; } = new ();

        public List<string> Additions { get; } = new ();

        public string CustomDescription { get; set; }

        protected string Order 
        { 
            get
            {
                var list = String.Empty;

                if (Ingredients.Count > 0)
                {
                    list += "Ingredients: ";
                    foreach (var ingredient in Ingredients)
                        list += ingredient + ", ";

                    if (Additions.Count > 0)
                    {
                        list = list.Substring(0, list.Length - 2) + ".\nAdditions: ";
                        foreach (var addition in Additions)
                            list += addition + ", ";

                        return list.Substring(0, list.Length - 2);
                    }

                    return list.Substring(0, list.Length - 2);
                }                
                
                return "nothing";
            } 
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        } 

        public abstract List<Ingredient> GetIngredients();
    }
}
