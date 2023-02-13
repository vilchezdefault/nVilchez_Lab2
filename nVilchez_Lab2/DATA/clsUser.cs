using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsUser
    {
        #region Attributes
        private String UserName;
        private String password;
        #endregion Attibutes
        #region Builders

        public clsUser()
        {
            this.UserName = "";
            this.password = "";
        } 

        public clsUser(String UserName, String Password) 
        {

        }    

        #endregion Builder
        #region Functioons N procedures
        public string printData()
        {
            string data = "";
            data = "Username" + this.UserName + "\n" +
                   "Password" + this.password + "\n";
            return data;
        }
        #endregion  Function N procedures
        #region Gets N Set
        public String UserName_prop
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public String Password_prop
        {
            get { return password; }
            set { password = value; }
        }
        #endregion
    }
}
