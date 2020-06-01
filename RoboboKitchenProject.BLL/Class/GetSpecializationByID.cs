using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.BLL.Class
{
   public static class GetSpecializationByID
    {

        public static string Get(int id, List<Spealization> specs)
        {
            return specs[id - 1].Name;
        }
    }
}
