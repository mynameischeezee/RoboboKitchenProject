using RoboboKitchenProject.BLL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.Model
{
   public static class Kitchen
    {
        
       static public List<Cook> Cooks;
       static private Dictionary<Order, Cook> Orders;
        

        static public void AddOrder(Order order, Cook cook)
        {
            Orders.Add(order, cook);
            Kitchen.RemoveCook(cook);
        }
        static public void AddCook(Cook cook)
        {
            Cooks.Add(cook);
        }

        static public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }
        static public void RemoveCook(Cook cook)
        {
            Cooks.Remove(cook);
        }
        static public List<Cook> GetCooks()
        {
            return Cooks;
        }
        static Kitchen()
        {
            Cooks = new List<Cook>();
            //Cook cook = new Cook("Jim", "Cook", "MexicanFood");
            //Cook sousChef = new Cook("Pam", "SousChef", "MexicanFood", "ItalianFood");
            //Cook chef = new Cook("Michael", "Chef", "MexicanFood", "ItalianFood", "AsianFood");
            //Cooks.Add(cook);
            //Cooks.Add(sousChef);
            //Cooks.Add(chef);
            Orders = new Dictionary<Order, Cook>();
        }
    }
}
