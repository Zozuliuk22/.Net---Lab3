using Menu;
using System.Collections.Generic;

namespace Application
{
    public class Customer
    {
        public string Name { get; set; }

        public int RoomNumber { get; set; }

        public Dictionary<string, List<Dish>> Order { get; set; } = new();
    }
}
