using Menu.Interfaces;
using Menu.AbstractProducts;
using Menu.Products.Beverages;
using Menu.Products.Desserts;
using Menu.Products.MainDishes;
using Menu.Products.Appetizers;

namespace Menu.Factories
{
    public class DinnerFactory : IFactory
    {
        public Beverage CreateBeverage()
        {
            return new BeverageDinner();
        }

        public Dessert CreateDessert()
        {
            return new DessertDinner();
        }

        public MainDish CreateMainDish()
        {
            return new MainDishDinner();
        }

        public Appetizer CreateAppetizer()
        {
            return new AppetizerDinner();
        }
    }
}
