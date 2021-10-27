using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using Joole.Repo;

namespace Joole.Service
{
    public class UserService : IUserService
    {
        private IRepository<tblUser> userRepository;

        public UserService(IRepository<tblUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<tblUser> getUsers()
        {
            return userRepository.getAll();
        }

        public tblUser getUser(int id)
        {
            return userRepository.Get(id);
        }
    }
}
