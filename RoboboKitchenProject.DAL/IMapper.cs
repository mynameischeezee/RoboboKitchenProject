using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL
{
    public interface IMapper<TModel, TEntity>
    {
        TModel MapTo(TEntity data);

    }
}
