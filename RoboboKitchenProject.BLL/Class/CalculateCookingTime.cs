using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoboboKitchenProject.Model
{
    public static class CalculateCookingTime
    {
        public static DateTime ReturnTime(Cook cook, Dish dish)
        {
            TimeSpan Time = TimeSpan.FromMinutes(dish.CookingTime * ConvertQualification.Convert(cook));
            DateTime CookingTime = DateTime.Now + Time;
            return CookingTime;
        }
    }
}
