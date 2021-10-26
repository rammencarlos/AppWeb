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
        public UserDTO CreateUser(UserDTO user)
        {
            user.IsEnabled = true;
            user.CreatedDate = DateTime.Now;

            int returnValue = new UserDA().CreateUser(user);
            user.Id = returnValue;

            return user;
        }


    }
}
