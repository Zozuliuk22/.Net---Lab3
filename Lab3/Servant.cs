using System;
using System.Collections.Generic;
using Menu;
using Menu.Interfaces;
using Menu.AbstractProducts;

namespace Application
{
    public static class Servant
    {
        public static List<Dish> ServeFood(IFactory factory)
        {
            var order = new List<Dish>();

            foreach (var foodType in BeginningData.FoodTypes)
            {
                var answer = ConsoleViewer.ReadAnswer(foodType.Key);
                if (answer == ConsoleKey.Y)
                {
                    var result = foodType.Value.Invoke(factory, null);

                    var appetizer = result as Appetizer;
                    if (appetizer is not null)
                        order.Add(ServeAppetizer(appetizer));

                    var beverage = result as Beverage;
                    if (beverage is not null)
                        order.Add(ServeBeverage(beverage));

                    var dessert = result as Dessert;
                    if (dessert is not null)
                        order.Add(ServeDessert(dessert));

                    var mainDish = result as MainDish;
                    if (mainDish is not null)
                        order.Add(ServeMainDish(mainDish));
                }
            }
            return order;
        }

        static Dish ServeAppetizer(Appetizer appetizer)
        {
            var ingredients = appetizer.GetIngredients();
            ConsoleViewer.ShowIngredients(ingredients);
            Console.WriteLine("Choose ingredient: ");
            int position = 1;
            position = Int32.Parse(Console.ReadLine());
            while (position > 0 && position <= ingredients.Count)
            {
                appetizer.AddIngredient(ingredients[position - 1]);
                Console.WriteLine("Choose ingredient: ");
                position = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter description : ");
            string description = Console.ReadLine();
            appetizer.CustomDescription = description;
            appetizer.AddGloves();
            return appetizer;
        }

        static Dish ServeBeverage(Beverage beverage)
        {
            var ingredients = beverage.GetIngredients();
            ConsoleViewer.ShowIngredients(ingredients);
            Console.WriteLine("Choose ingredient: ");
            int position = 1;
            position = Int32.Parse(Console.ReadLine());
            while (position > 0 && position <= ingredients.Count)
            {
                beverage.AddIngredient(ingredients[position - 1]);
                Console.WriteLine("Choose ingredient: ");
                position = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter description : ");
            string description = Console.ReadLine();
            beverage.CustomDescription = description;
            beverage.AddIceCubes()
                    .AddGlassLabel();

            return beverage;
        }

        static Dish ServeDessert(Dessert dessert)
        {
            var ingredients = dessert.GetIngredients();
            ConsoleViewer.ShowIngredients(ingredients);
            Console.WriteLine("Choose ingredient: ");
            int position = 1;
            position = Int32.Parse(Console.ReadLine());
            while (position > 0 && position <= ingredients.Count)
            {
                dessert.AddIngredient(ingredients[position - 1]);
                Console.WriteLine("Choose ingredient: ");
                position = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter description : ");
            string description = Console.ReadLine();
            dessert.CustomDescription = description;
            dessert.AddPresentationAttribute();

            return dessert;
        }

        static Dish ServeMainDish(MainDish mainDish)
        {
            var ingredients = mainDish.GetIngredients();
            ConsoleViewer.ShowIngredients(ingredients);
            Console.WriteLine("Choose ingredient: ");
            int position = 1;
            position = Int32.Parse(Console.ReadLine());
            while (position > 0 && position <= ingredients.Count)
            {
                mainDish.AddIngredient(ingredients[position - 1]);
                Console.WriteLine("Choose ingredient: ");
                position = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter description : ");
            string description = Console.ReadLine();
            mainDish.CustomDescription = description;
            mainDish.AddGlassOfWater();

            return mainDish;
        }
    }
}
