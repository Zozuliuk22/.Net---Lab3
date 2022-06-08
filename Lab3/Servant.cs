using System;
using System.Collections.Generic;
using System.Reflection;
using Menu;
using Menu.Interfaces;
using Menu.AbstractProducts;
using System.Linq;

namespace Application
{
    public class Servant
    {
        private Dictionary<string, MethodInfo> _createFoodTypesMethods = new();

        private Dictionary<string, MethodInfo> _serveFoodTypesMethods = new();

        private void InitializeCreateFoodTypesMethods()
        {
            var type = typeof(IFactory);
            var methods = type.GetMethods();
            foreach (var method in methods)
                _createFoodTypesMethods.Add(method.Name.Replace("Create", ""), method);
        }

        private void InitializeServeFoodTypesMethods()
        {
            var type = typeof(Servant);
            var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                              .Where(m => m.Name.ToLower().StartsWith("serve") && 
                                         !m.Name.ToLower().EndsWith("dish"));

            foreach (var method in methods)
                _serveFoodTypesMethods.Add(method.Name.Replace("Serve", ""), method);
        }

        public Servant()
        {
            InitializeCreateFoodTypesMethods();
            InitializeServeFoodTypesMethods();
        }

        public List<Dish> ServeFood(IFactory factory)
        {
            var order = new List<Dish>();

            foreach (var foodType in _createFoodTypesMethods)
            {
                var answer = ConsoleViewer.ReadAnswer(foodType.Key);
                if (answer == ConsoleKey.Y)
                {
                    var emptyDish = foodType.Value.Invoke(factory, null);
                    var dish = _serveFoodTypesMethods[foodType.Key].Invoke(this, new object[] { emptyDish });
                    if(dish != null) order.Add(dish as Dish);
                }
            }
            return order;
        }

        private Dish ServeDish(Dish dish)
        {
            var ingredients = dish.GetIngredients();
            if (ingredients.Count == 0) return null;

            ConsoleViewer.ShowIngredients(ingredients);

            var position = ConsoleViewer.ReadIngredient();            
            while (position > 0 && position <= ingredients.Count)
            {
                dish.AddIngredient(ingredients[position - 1]);
                position = ConsoleViewer.ReadIngredient();
            }

            if(dish.Ingredients.Count == 0) return null;
            
            dish.CustomDescription = ConsoleViewer.ReadDescription();
            return dish;
        }

        private Dish ServeAppetizer(object dish)
        {
            var appetizer = dish as Appetizer;
            if (appetizer == null) return null;

            var result = ServeDish(appetizer);
            if(result == null) return null;

            return (dish as Appetizer).AddGloves();
        }

        private Dish ServeBeverage(object dish)
        {
            var beverage = dish as Beverage;
            if (beverage == null) return null;

            var result = ServeDish(beverage);
            if (result == null) return null;

            return (dish as Beverage).AddIceCubes()
                                     .AddGlassLabel();
        }

        private Dish ServeDessert(object dish)
        {
            var dessert = dish as Dessert;
            if (dessert == null) return null;

            var result = ServeDish(dessert);
            if (result == null) return null;

            return (dish as Dessert).AddPresentationAttribute();
        }

        private Dish ServeMainDish(object dish)
        {
            var mainDish = dish as MainDish;
            if (mainDish == null) return null;

            var result = ServeDish(mainDish);
            if (result == null) return null;

            return (dish as MainDish).AddGlassOfWater();
        }
    }
}
