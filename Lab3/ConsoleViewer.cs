using System;
using System.Collections.Generic;
using Application.Properties;
using Storage;

namespace Application
{
    public static class ConsoleViewer
    {
        public static void ShowWelcomeWord()
        {
            Console.WriteLine(ConsoleTexts.WelcomeWord + "\n");
        }

        public static void ShowIngredients(List<Ingredient> ingredients)
        {
            for (int i = 0; i < ingredients.Count; i++)
                Console.WriteLine($"\t{i+1} - {ingredients[i]}");
        }

        public static void ShowOrder(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine($"Order for {customer.Name}, room {customer.RoomNumber}.");
            if (customer.Order.Count > 0)
            {
                foreach (var position in customer.Order)
                {
                    Console.WriteLine($"Your {position.Key}.");
                    foreach (var dish in position.Value)
                        Console.WriteLine($"\n{dish}");
                }
            }
            else 
                Console.WriteLine("No dishes exist.");
        }

        public static ConsoleKey ReadAnswer(string mainWord)
        {
            Console.Write($"Do you want to have {mainWord} ? [y/n]  ");
            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key;
        }

        public static string ReadName()
        {
            Console.Write("Please, enter your name: ");
            return Console.ReadLine();
        }

        public static int ReadRoomNumber()
        {
            var roomNumber = 0;
            Console.Write("Please, enter your room number: ");
            var number = Console.ReadLine();
            while (!Int32.TryParse(number, out roomNumber) || roomNumber <= 0)
            {
                Console.Write("Please, enter your room number: ");
                number = Console.ReadLine();
            }
            return roomNumber;
        }

        public static int ReadIngredient()
        {
            var position = 0;
            Console.Write("Please, choose ingredient (or enter \"0\" to exit): ");
            var number = Console.ReadLine();
            while (!Int32.TryParse(number, out position))
            {
                Console.Write("Please, choose ingredient (or enter \"0\" to exit): ");
                number = Console.ReadLine();
            }
            return position;
        }

        public static string ReadDescription()
        {
            Console.Write("\nPlease, enter description, if you need. If you don't need just tap \"Enter\": ");
            return Console.ReadLine();
        }
    }
}
