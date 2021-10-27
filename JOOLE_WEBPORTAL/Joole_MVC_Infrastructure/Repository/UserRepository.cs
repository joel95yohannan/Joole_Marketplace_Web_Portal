using Joole_MVC_Core;
using Joole_MVC_Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        JooleDataBaseEntities _entities;
        public List<UserUI> GetAllUsers()
        {
            _entities = new JooleDataBaseEntities();
            var _lstUserUI = new List<UserUI>();
            var _lstUsers = _entities.tblUsers.ToList();

            foreach (var user in _lstUsers) {
                _lstUserUI.Add(new UserUI
                {
                    UserID = user.UserID,
                    UserName = user.UserName,
                    UserEmail = user.UserEmail,
                    UserPassword = user.UserPassword
                    //UserImage = user.UserImage
                });
            }
            return _lstUserUI;
        }
    }
}
