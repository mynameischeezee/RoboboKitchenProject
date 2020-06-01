using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoboboKitchenProject.Model
{
   public class Cook
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CookQualification { get; set; }
        public List<string> Specialization;

        public Cook( string name, string qualification, params string[] type)
        {
            Name = name;
            CookQualification = qualification;
            Specialization = new List<string>();
            foreach (string element in type)
            {
                Specialization.Add(element);
            }
        }
        public Cook(int id, string name, string qualification, List<string> type)
        {
            ID = id;
            Name = name;
            CookQualification = qualification;
            Specialization = type;
            
        }
        public Cook(int id, string name, string qualification, params string[] type)
        {
            ID = id;  
            Name = name;
            CookQualification = qualification;
            Specialization = new List<string>();
            foreach (string element in type)
            {
                Specialization.Add(element);
            }
        }
        public Cook(int id, string name, string qualification)
        {
            ID = id;
            Name = name;
            CookQualification = qualification;
            
        }
        public Cook()
        {
            
        }
    }
}
