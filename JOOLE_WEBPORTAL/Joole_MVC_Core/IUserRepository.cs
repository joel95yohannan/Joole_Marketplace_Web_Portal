using Joole_MVC_Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Core
{
    public interface IUserRepository
    {
        List<UserUI> GetAllUsers();
    }
}
