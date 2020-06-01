using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoboboKitchenProject.DAL.Abstract;
using RoboboKitchenProject.Entity;
using RoboboKitchenProject.Model;

namespace RoboboKitchenProject.DAL.Impl
{
    public class CookRepository : GenericRepository<CookEntity>, ICookRepository
    {
       public CookRepository(RoboboDataContext context) : base(context)
        {

        } 
    }
        
    
}
