using Storage;
using System;
using System.Collections.Generic;
using System.Text;

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
                var sb = new StringBuilder();

                if (Ingredients.Count > 0)
                {
                    sb.Append("\n\tIngredients: ");
                    foreach (var ingredient in Ingredients)
                        sb.Append($"{ingredient}, ");

                    if (Additions.Count > 0)
                    {
                        sb.Remove(sb.Length - 2, 2);
                        sb.Append(".\n\tAdditions: ");
                        foreach (var addition in Additions)
                            sb.Append($"{addition}, ");
                    }

                    return sb.Remove(sb.Length - 2, 2).ToString();
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
