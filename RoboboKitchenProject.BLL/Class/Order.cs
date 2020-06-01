 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RoboboKitchenProject.Model
{
    public class Order
    {
        public int ID { get; set; }
        public Dish DishName { get; set; }
        public DateTime CookingTime { get; set; }
        public Cook OrderCook { get; set; }
        public string NameOfDish { get; set; }
        public DateTime OrderTime { get; set;}

        public Order()
        { }
       public Order(Dish dish)
        {

            try
            {
                DishName = dish;
                OrderCook = SetCook.ReturnAvalibleCook(dish);
                CookingTime = CalculateCookingTime.ReturnTime(OrderCook, dish);
                OrderTime = DateTime.Now;
                NameOfDish = DishName.Name;
                
            }
            catch
            {

                MessageBox.Show("No avalible cook", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
