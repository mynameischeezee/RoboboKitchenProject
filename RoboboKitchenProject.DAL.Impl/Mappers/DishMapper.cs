using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboboKitchenProject.Entity;
using RoboboKitchenProject.Model;

namespace RoboboKitchenProject.DAL.Impl.Mappers
{
    public class DishMapper : IMapper<Dish, DishEntity>
    {
        public DishMapper()
        { 
        }
        public Dish MapTo(DishEntity data)
        {
            return new Dish()
            {
                ID = data.ID,
                Name = data.Name,
                Indgradients = data.Indgradients,
                CookingTime = data.CookingTime,
                Type = data.Type,
                Weight = data.Weight,
                Cost = data.Cost
            };
        }
        public List<Dish> Map(List<DishEntity> models)
        {
            return models.Select(obj => MapTo(obj)).ToList();
        }
    }
}
