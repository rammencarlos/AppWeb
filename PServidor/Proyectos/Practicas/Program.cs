using Practicas.Security;
using System;
using System.Collections.Generic;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            UserEntity newUser = new UserEntity();
            newUser.UserName = "Osito.Panda";

            UserCore userCore = new UserCore();
            List<UserEntity> listUsers = userCore._listUsers;

            foreach (UserEntity user in listUsers)
            {
                Console.WriteLine("Id: " + user.Id);
                Console.WriteLine("UserName: " + user.UserName);
            }

            int newId = userCore.CreateUser(newUser);
            if (newId == 0)
            {
                Console.WriteLine("Error al generar el Id");
            }
            else
            {
                Console.WriteLine("Se agrego exitosamente el usuario");
            }


            foreach (UserEntity user in listUsers)
            {
                Console.WriteLine("Id: " + user.Id);
                Console.WriteLine("UserName: " + user.UserName);
            }



        }
    }
}
