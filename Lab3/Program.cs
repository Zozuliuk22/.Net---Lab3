using System;
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

            var servant = new Servant();

            foreach (var factory in Constants.Factories)
            {
                var answer = ConsoleViewer.ReadAnswer(factory.Key);
                if(answer == ConsoleKey.Y)
                    customer.Order.Add(factory.Key, servant.ServeFood(factory.Value));
            }

            ConsoleViewer.ShowOrder(customer);
        }
    }
}
