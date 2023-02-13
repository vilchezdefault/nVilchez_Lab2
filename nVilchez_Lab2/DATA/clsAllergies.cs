using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsAllergies
    {
        #region Attributtes
        private int IDAllergie;
        private int num_idCustomer;
        private string kindOfAllergie;
        #endregion Attributes
        #region constructors
        public clsAllergies()
        {
            this.IDAllergie = 0;
            this.num_idCustomer = 0;
            this.kindOfAllergie = "";
        }
        public clsAllergies(int iDAllergie, int numID, string kindOfAllergie, int iDAllergie_prop, int numID_prop, string myProperty)
        {
            IDAllergie = iDAllergie;
            this.num_idCustomer = numID;
            this.kindOfAllergie = kindOfAllergie;
            IDAllergie_prop = iDAllergie_prop;
            this.numID_prop = numID_prop;
            MyProperty = myProperty;
        }

        #endregion constructors
        #region Functions or procedure
        public string printData()
        {
            string data = "";
            data = "ID Allergie" + this.IDAllergie + "\n" +
                    "Name or Kind of allergie" + this.kindOfAllergie + "\n";
            return data;
        }
        #endregion
        #region Gets & Sets
        public int IDAllergie_prop
        {
            get { return IDAllergie; }
            set { IDAllergie = value; }
        }
        public int numID_prop
        {
            get { return num_idCustomer; }
            set { num_idCustomer = value; }
        }
        public string MyProperty
        {
            get { return kindOfAllergie; }
            set { kindOfAllergie = value; }
        }
        #endregion Gets N Sets

    }
}
