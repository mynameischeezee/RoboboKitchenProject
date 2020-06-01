using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoboboKitchenProject.Model
{
   public static class SetCook
    {
        public static Cook ReturnAvalibleCook(Dish dish)
        {
            List<Cook> cooks = Kitchen.GetCooks();
            foreach (Cook cook in cooks)
            {
                if (cook.Specialization.Contains(dish.Type))
                {
                    return cook;
                } 
            }
            throw new ArgumentException("No avalible cook.");
        }
    }
}
