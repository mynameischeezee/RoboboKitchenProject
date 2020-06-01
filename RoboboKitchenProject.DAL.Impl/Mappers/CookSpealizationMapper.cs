using RoboboKitchenProject.BLL.Class;
using RoboboKitchenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL.Impl.Mappers
{
    public class CookSpealizationMapper
    {
        public  CookSpealization MapTo(CookSpecializationEntity data)
        {
            return new CookSpealization()
            {
                ID = data.ID,
                CookID = data.CookID,
                SpealizationID = data.SpecializationID

            };

        }
        public List<CookSpealization> Map(List<CookSpecializationEntity> models)
        {
            return models.Select(obj => MapTo(obj)).ToList();
        }
    }
}
