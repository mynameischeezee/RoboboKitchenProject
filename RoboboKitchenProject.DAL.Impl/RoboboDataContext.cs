using RoboboKitchenProject.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RoboboKitchenProject.DAL.Impl
{
    public class RoboboDataContext : DbContext
    {
        public RoboboDataContext() : base(ConfigurationManager.ConnectionStrings["ConnStrDataContext"].ConnectionString)
        { 

        }
        public DbSet<CookEntity> Cook { get; set; }
        public DbSet<CookSpecializationEntity> CookSpecialization { get; set; }
        public DbSet<DishEntity> Dish { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<SpecializationEntity> Specialization { get; set; }
         
    }
} 
