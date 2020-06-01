using RoboboKitchenProject.Entity;
using RoboboKitchenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL.Impl.Mappers
{
    public class OrderMapper
    {
        public OrderMapper()
        {
        }

        public void DeMap(Order model, UnitOfWorkImpl _UnitOfWork)
        {
            _UnitOfWork.Orders.Insert(new OrderEntity
            {
                ID = model.ID,
                NameOfDish = model.DishName.Name,
                OrderTime = model.OrderTime
            }) ;
        }
    }
}
