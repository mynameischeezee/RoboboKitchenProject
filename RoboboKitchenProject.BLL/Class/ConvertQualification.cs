using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoboboKitchenProject.Model
{
   public static class ConvertQualification
    {
        public static double Convert(Cook cook)
        {
            if (cook.CookQualification == "Cook")
            {
                return 2.0;
            }
            else if (cook.CookQualification == "SousChef")
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
           
        }
    }
}
