using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Security
{
    public class UserCore
    {
        public List<UserEntity> _listUsers;

        public UserCore()
        {
            _listUsers = new List<UserEntity>();

            //Forma corta de agregar un objeto del tipo UserEntity
            _listUsers.Add(new UserEntity()
            {
                Id = 1,
                UserName = "Osito.Pardo"
            });

            //Forma larga de agregar un objeto...
            UserEntity userEntity = new UserEntity();
            userEntity.Id = 2;
            userEntity.UserName = "Osito.Polar";
            _listUsers.Add(userEntity);

        }

        //CRUD
        public int CreateUser(UserEntity userEntity)
        {
            userEntity.Id = GenerateRandomNum();

            if (userEntity.Id != 0)
            {
                _listUsers.Add(userEntity);
            }

            return userEntity.Id;
        }

        private int GenerateRandomNum()
        {
            try
            {
                var rand = new Random();
                int number = rand.Next(200, 1000);

                if (number % 2 != 0)
                {
                    //generar error en caso de que sea impar
                    throw new Exception();
                }
              
                return number;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
