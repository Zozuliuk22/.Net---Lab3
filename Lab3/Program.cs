using System;
using Menu.Interfaces;
using Application;

namespace Lab3
{
    public class Program
    { 
        static void Main(string[] args)
        {  
            ConsoleViewer.ShowWelcomeWord();

            var customer = new Customer();
            customer.Name = ConsoleViewer.ReadName();
            customer.RoomNumber = ConsoleViewer.ReadRoomNumber();

            GetFoodTypes();

            foreach (var factory in BeginningData.Factories)
            {
                var answer = ConsoleViewer.ReadAnswer(factory.Key);
                if(answer == ConsoleKey.Y)
                    customer.Order.Add(factory.Key, Servant.ServeFood(factory.Value));
            }

            ConsoleViewer.ShowOrder(customer);
        }        

        static void GetFoodTypes()
        {
            var type = typeof(IFactory);
            var methods = type.GetMethods();
            foreach(var method in methods)
                BeginningData.FoodTypes.Add(method.Name.Replace("Create", ""), method);
        }
    }
}
