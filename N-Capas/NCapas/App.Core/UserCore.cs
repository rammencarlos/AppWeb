using App.DataAccess;
using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public class UserCore
    {
        public UserDTO Create(UserDTO user)
        {
            user.IsEnabled = true;
            user.CreatedDate = DateTime.Now;

            int returnValue = new UserDA().CreateUser(user);
            user.Id = returnValue;

            return user;
        }


        public List<UserDTO> List()
        {
            List<UserDTO> users = new UserDA().List();
            return users;
        }

        public UserDTO Get(int id)
        {
            UserDTO user = new UserDA().Get(id);
            return user;
        }

        public bool Update(UserDTO user)
        {
            user.UpdatedDate = DateTime.Now;

            bool isUpdated = new UserDA().Update(user);
            return isUpdated;
        }

    }
}
