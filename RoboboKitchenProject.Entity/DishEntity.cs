using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoboboKitchenProject.Entity
{
    public class DishEntity : IEntity<int>
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Indgradients { get; set; }
        public double CookingTime { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
    }
}
