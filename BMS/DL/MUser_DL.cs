using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
using BMS.UI;

namespace BMS.DL
{
    class MUser_DL
    {
        private static string usersPath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\users.txt";
        public static void addIntoList(MUser user)
        {
            MUser.users.Add(user);
        }
        public static MUser signIn(string name,string password)
        {
            foreach (var storedUser in MUser.users)
            {
                if (name == storedUser.Naam && password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static bool isAlreadyExists(string name,string password)
        {
            foreach(MUser storedUser in MUser.users)
            {
                if((name==storedUser.Naam)&&(password==storedUser.password))
                {
                    return false;
                }
            }
            return true;
        }

       
    }
}
