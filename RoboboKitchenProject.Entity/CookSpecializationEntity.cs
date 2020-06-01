using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RoboboKitchenProject.Model;

namespace RoboboKitchenProject.Entity
{
   public class CookSpecializationEntity : IEntity<int>
    {
        [Key]
        public int ID { get; set; }

        [AllowNull]
        public int CookID { get; set; }

        [ForeignKey(nameof(CookID))]
        public CookEntity Cook { get; set; }

        [AllowNull]
        public int SpecializationID { get; set; }

        [ForeignKey(nameof(SpecializationID))]
        public SpecializationEntity Qualification { get; set; }
    }
}
