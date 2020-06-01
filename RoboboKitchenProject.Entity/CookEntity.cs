using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.Entity
{
    public class CookEntity : IEntity<int>
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Qualification { get; set; }
    }
}
