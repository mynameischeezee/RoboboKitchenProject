using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboboKitchenProject.Entity;
using RoboboKitchenProject.Model;

namespace RoboboKitchenProject.DAL.Impl.Mappers
{
    public  class CookMapper : IMapper<Cook, CookEntity>
    {
        public  Cook MapTo(CookEntity data)
        {
            return new Cook()
            {
                ID = data.ID,
                Name = data.Name,
                CookQualification = data.Qualification
            };
            

        }
        public List<Cook> Map(List<CookEntity> models)
        {
            return models.Select(obj => MapTo(obj)).ToList();
        }


    }
}
