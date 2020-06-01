using RoboboKitchenProject.BLL.Class;
using RoboboKitchenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL.Impl.Mappers
{
    public class SpealizationMapper : IMapper<Spealization, SpecializationEntity>
    {
        public Spealization MapTo(SpecializationEntity data)
        {
            return new Spealization()
            {
                ID = data.ID,
                Name = data.Name,
            };

        }
        public List<Spealization> Map(List<SpecializationEntity> models)
        {
            return models.Select(obj => MapTo(obj)).ToList();
        }
    }
}
