using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsBranches
    {
        #region attributtes
        private int id_branch;
        private int legalID;
        private string name;
        private string local_phone;
        private string email;
        #endregion attributtes
        #region constructors
        public clsBranches()
        {
            this.id_branch= 0;
            this.legalID= 0;
            this.name= "";
            this.local_phone = "";
            this.email = "";            
        }

        public clsBranches(int id_branch, int legalID, string name, string local_phone, string email)
        {
            this.id_branch = id_branch;
            this.legalID = legalID;
            this.name = name;
            this.local_phone = local_phone;
            this.email = email;
        }

        #endregion constructors

        #region Sets & Gets
        public int Id_brand_prop
        {
            get { return id_branch; }
            set { id_branch = value; }
        }
        public int LegalID
        {
            get { return legalID; }
            set { legalID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Local_phone
        {
            get { return local_phone; }
            set { local_phone = value; }
        }
        #endregion Sets & Gets

        #region procedure or functions
        public string printData()
        {
            string data = "";
            data = " Branch" + this.id_branch + "\n" + 
                    "Legal ID" + this.legalID + "\n" + 
                    "Local" + this.name + "\n" + 
                    "Phone" + this.local_phone +
                    "\n" + "";
            return data;
        }
        #endregion

    }
}
