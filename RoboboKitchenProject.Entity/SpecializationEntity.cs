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
    public class SpecializationEntity : IEntity<int>
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
