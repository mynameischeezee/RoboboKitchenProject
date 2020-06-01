using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.Model
{
    public class Dishes
    {
       public List<Dish> dishes = new List<Dish>();
        public List<Dish> GetDishes()
        {
            return dishes;
        }
        public Dishes()
        {
            dishes.Add(new Dish("Sushi", "Fish, weed", 30.0, "AsianFood", 400, 5.0));
            dishes.Add(new Dish("Taco", "Tortilia, Meet, Sauce", 10.0, "MexicanFood", 300, 2.0));
            dishes.Add(new Dish("Pizza", "Cheese, Bread, Meat, Sause", 45.0, "ItalianFood", 700, 7.0));
            dishes.Add(new Dish("Pasta", "Pasta, Meat, Sauce", 15.0, "ItalianFood", 350, 4.0));
            dishes.Add(new Dish("Wok", "Woak, Vegetables, Meat, Egg", 10.0, "AsianFood", 400, 5.0));
            dishes.Add(new Dish("Buritto", "Tortilia, Meet", 5.0, "MexicanFood", 300, 3.0));
    }
    }
}
