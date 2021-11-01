using Joole_MVC_Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Core
{
    public interface IProductRepository
    {
        List<ProductsUI> GetAllProucts();
        List<ProductsUI> GetFans();
        List<ProductsUI> GetVacuums();
        List<ProductsUI> GetToasters();
    }
}
