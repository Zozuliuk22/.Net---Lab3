using Menu.Interfaces;
using Menu.AbstractProducts;
using Menu.Products.Beverages;
using Menu.Products.Desserts;
using Menu.Products.MainDishes;
using Menu.Products.Appetizers;

namespace Menu.Factories
{
    public class SupperFactory : IFactory
    {
        public Beverage CreateBeverage()
        {
            return new BeverageSupper();
        }

        public Dessert CreateDessert()
        {
            return new DessertSupper();
        }

        public MainDish CreateMainDish()
        {
            return new MainDishSupper();
        }

        public Appetizer CreateAppetizer()
        {
            return new AppetizerSupper();
        }
    }
}
