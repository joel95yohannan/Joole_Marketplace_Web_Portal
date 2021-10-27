using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
/*Uses Data Context Class(JooleModel.Context.cs) From Joole.Data*/

namespace Joole.Repo
{
    public interface IRepository<T> where T: class   //Generic Repository Interface For Entity Operations
    {
        IEnumerable<T> getAll();
        T Get(int id);
    }
}
