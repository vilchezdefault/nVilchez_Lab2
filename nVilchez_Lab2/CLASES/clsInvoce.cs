using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsInvoce
    {
        #region attributtes
        private int id_bill;
        private int id_branch;
        private decimal totalcheck;
        private string kindOfPaid;
        #endregion
        #region constructors
        public clsInvoce()
        {
            this.id_bill = 0;
            this.id_branch = 0;
            this.totalcheck = 0;
            this.kindOfPaid= "";
        }

        public clsInvoce(int id_bill, int id_branch, decimal totalcheck, string kindOfPaid)
        {
            this.id_bill = id_bill;
            this.id_branch = id_branch;
            this.totalcheck = totalcheck;
            this.kindOfPaid = kindOfPaid;
        }


        #endregion
        #region functions or procedures
        public string printData()
        {
            string data = "";
            data = "Bill" + this.id_bill + "\n" + 
                    "Local" + this.id_branch + "\n" + 
                    "Total" + this.totalcheck + "\n" +
                    "Method of payment" + this.kindOfPaid + "\n";
            return data;
        }
        #endregion
        #region Sets & Gets
        public string KindOfPaid
        {
            get { return kindOfPaid; }
            set { kindOfPaid = value; }
        }

        public decimal Totalcheck
        {
            get { return totalcheck; }
            set { totalcheck = value; }
        }

        public int Id_branch
        {
            get { return id_branch; }
            set { id_branch = value; }
        }

        public int Id_bill
        {
            get { return id_bill; }
            set { id_bill = value; }
        }
        #endregion
    }
}
