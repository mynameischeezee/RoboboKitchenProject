using RoboboKitchenProject.BLL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboboKitchenProject.Entity;

namespace RoboboKitchenProject.DAL.Impl
{
   public class SpecializationRepository : GenericRepository<SpecializationEntity>, ISpecializationRepository
    {
        public SpecializationRepository(RoboboDataContext context) : base(context)
        {

        }
    }
}
