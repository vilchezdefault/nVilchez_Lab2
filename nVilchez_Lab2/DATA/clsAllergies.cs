using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_Lab2.DATA
{
    internal class clsAllergies
    {
        #region Attributes
        private int IDAllergie;
        private int numID;
        private String kindOfAllergie;
        #endregion Attributes
        #region Builders
        public clsAllergies()
        {
            this.IDAllergie = 0;
            this.numID = 0;
            this.kindOfAllergie = "";
        }
        public clsAllergies(int iDAllergie, int numID, string kindOfAllergie, int iDAllergie_prop, int numID_prop, string myProperty)
        {
            IDAllergie = iDAllergie;
            this.numID = numID;
            this.kindOfAllergie = kindOfAllergie;
            IDAllergie_prop = iDAllergie_prop;
            this.numID_prop = numID_prop;
            MyProperty = myProperty;
        }

        #endregion Builders
        #region Functions N procedures
        public string printData()
        {
            string data = "";
            data = "ID Allergie" + this.IDAllergie + "\n" +
                    "Name or Kind of allergie" + this.kindOfAllergie + "\n";
            return data;
        }
        #endregion
        #region Gets N Sets
        public int IDAllergie_prop
        {
            get { return IDAllergie; }
            set { IDAllergie = value; }
        }
        public int numID_prop
        {
            get { return numID; }
            set { numID = value; }
        }
        public String MyProperty
        {
            get { return kindOfAllergie; }
            set { kindOfAllergie = value; }
        }
        #endregion Gets N Sets

    }
}
