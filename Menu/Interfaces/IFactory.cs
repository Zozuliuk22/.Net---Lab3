using Menu.AbstractProducts;

namespace Menu.Interfaces
{
    public interface IFactory
    {
        Appetizer CreateAppetizer();        
        MainDish CreateMainDish();
        Dessert CreateDessert();
        Beverage CreateBeverage();
    }
}
