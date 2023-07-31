using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMS.BL
{
    class MUser
    {
        protected string Name;
        protected string Password;
        protected string Role;
        public static List<MUser> users = new List<MUser> ();
        
        public MUser(string mName, string mPassword, string mRole)
        {
            Name = mName;
            Password = mPassword;
            Role = mRole;
        }
        public string Naam
        {
            get { return Name; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string role
        {
            get { return Role; }
        }
        public MUser(string mName, string mPassword)
        {
            Name = mName;
            Password = mPassword;
        }

        public bool isAdmin()
        {
            if (Role == "admin")
            {
                return true;
            }
            else
                return false;
        }
        public virtual string saveDataInFile(string Path, StreamWriter f1)
        {

            return $"{Naam},{Password},{role}";
            
            
            
           
        }
        
        public virtual string toString()
        {
            return $" Role {Role} name is {Name} and password is {Password} ";
        }
    }
}