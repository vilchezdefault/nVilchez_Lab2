using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsUser
    {
        #region Attributtes
        private string UserName;
        private string password;
        #endregion Attibutes
        #region constructors

        public clsUser()
        {
            this.UserName = "";
            this.password = "";
        } 

        public clsUser(string UserName, string Password) 
        {
            this.UserName = UserName;
            this.password= Password;
        }    

        #endregion constructors
        #region Functioons or procedures
        public string printData()
        {
            string data = "";
            data = "Username" + this.UserName + "\n" +
                   "Password" + this.password + "\n";
            return data;
        }
        #endregion  Function or procedures
        #region Gets & Set
        public string UserName_prop
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string Password_prop
        {
            get { return password; }
            set { password = value; }
        }
        #endregion
    }
}
