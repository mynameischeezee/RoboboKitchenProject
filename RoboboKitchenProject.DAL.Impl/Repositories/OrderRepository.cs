using RoboboKitchenProject.DAL.Abstract;
using RoboboKitchenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL.Impl
{
    public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(RoboboDataContext context) : base(context)
        {

        }
    }
}
