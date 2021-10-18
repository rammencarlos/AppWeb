using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Persistence
{
    /// <summary>
    /// Generamos una clase e implementamos el patron Singleton
    /// </summary>
    public class UserRespository
    {
        public List<UserViewModel> _users;
        private readonly static UserRespository _intance = new UserRespository();

        public UserRespository()
        {
            _users = new List<UserViewModel>();
            UserViewModel userModel = new UserViewModel();
            userModel.Id = 1;
            userModel.UserName = "carlos.ramos";
            userModel.Name = "Carlos Ramos";
            userModel.Password = "1234";
            userModel.CreatedDate = DateTime.Now;
            _users.Add(userModel);
        }

        #region CRUD 
        public int CreateUser(UserViewModel user)
        {
            user.Id = GenerateRandomNum();
            user.CreatedDate = DateTime.Now;
            _users.Add(user);

            return user.Id;
        }

        public UserViewModel GetUser(int id)
        {
            UserViewModel user = null;

            foreach (UserViewModel userEval in _users)
            {
                if (userEval.Id == id)
                {
                    user = userEval;
                }
            }
            return user;
        }

        public bool UpdateUser(UserViewModel userUpdated)
        {
            UserViewModel userActual = GetUser(userUpdated.Id);

            foreach (UserViewModel userFinal in _users)
            {
                if (userFinal.Id == userActual.Id)
                {
                    userFinal.UserName = userUpdated.UserName;
                    userFinal.Password = userUpdated.Password;
                    userFinal.Name = userUpdated.Name;
                }
            }

            return true;
        }

        public bool DeleteUser(int id)
        {
            //metodo largo
            //UserViewModel userActual = GetUser(id);
            //_users.Remove(userActual);

            //Linq
            var item = _users.Single(r=> r.Id == id);
            _users.Remove(item);

            return true;
        }

        #endregion CRUD

        private int GenerateRandomNum()
        {
            try
            {
                var rand = new Random();
                int number = rand.Next(200, 1000);
                return number;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static UserRespository Instance
        {
            get
            {
                return _intance;
            }
        }

    }
}
