using Menu.Interfaces;
using Menu.AbstractProducts;
using Menu.Products.Beverages;
using Menu.Products.Desserts;
using Menu.Products.MainDishes;
using Menu.Products.Appetizers;

namespace Menu.Factories
{
    public class BreakfastFactory : IFactory
    {
        public Beverage CreateBeverage()
        {
            return new BeverageBreakfast();
        }

        public Dessert CreateDessert()
        {
            return new DessertBreakfast();
        }

        public MainDish CreateMainDish()
        {
            return new MainDishBreakfast();
        }

        public Appetizer CreateAppetizer()
        {
            return new AppetizerBreakfast();
        }
    }
}
