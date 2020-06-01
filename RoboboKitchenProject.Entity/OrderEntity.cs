using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.Entity
{
   public class OrderEntity : IEntity<int>
    {
        [Key]
        public int ID { get; set; }
        public string NameOfDish { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
