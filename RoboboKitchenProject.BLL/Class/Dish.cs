using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.Model
{
   public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Indgradients { get; set; }
        public double CookingTime { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }

        public Dish(string name, string ingradients, double time, string type, Double weight, Double cost)
        {
            Name = name;
            Indgradients = ingradients;
            CookingTime = time;
            Type = type;
            Weight = weight;
            Cost = cost;
        }
        public Dish()
        {

        }
    }
}
