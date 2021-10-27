using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;

namespace Joole.Service
{
    public interface IUserService
    {
        IEnumerable<tblUser> getUsers();
        tblUser getUser(int id);
    }
}
