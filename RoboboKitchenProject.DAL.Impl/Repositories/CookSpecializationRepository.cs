using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboboKitchenProject.Entity;

namespace RoboboKitchenProject.DAL.Impl
{
   public class CookSpecializationRepository : GenericRepository<CookSpecializationEntity>, ICookSpecializationRepository
    {
        public CookSpecializationRepository(RoboboDataContext context) : base(context)
        {

        }
    }
}
