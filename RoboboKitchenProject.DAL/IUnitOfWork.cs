using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL
{
    public interface IUnitOfWork
    {
        void Save();






        void Dispose();
        
    }
}
