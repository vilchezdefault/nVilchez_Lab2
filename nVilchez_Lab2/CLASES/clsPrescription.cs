using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_lab1.DATA
{
    public class clsPrescription
    {
        #region Attributes
        private int id_med_report;
        private int id_branch;
        private string treatment_descrip;
        private string dose;
        #endregion Attibutes
        #region Constructors
        public clsPrescription()
        {
            this.id_med_report = 0;
            this.id_branch = 0;
            this.treatment_descrip= "";
            this.dose = "";

        }

        public clsPrescription(int id_med_report, int id_branch, string treatment_descrip, string dose)
        {
            this.id_med_report = id_med_report;
            this.id_branch = id_branch;
            this.treatment_descrip = treatment_descrip;
            this.dose = dose;
        }

        #endregion
        #region functions or procedure
        public string dataPrint()
        {
            string data = "";
            data = "IDReport" + this.id_med_report + "\n" +
                    "Local" + this.id_branch + "\n" + 
                    "Treatment Desciption" + this.treatment_descrip + "\n+" +
                    "Dose" + this.dose + "\n";
            return data;
        }
        #endregion
        #region Sets & GETS
        public string Dose
        {
            get { return dose; }
            set { dose = value; }
        }

        public string Treatment_descrip
        {
            get { return treatment_descrip; }
            set { treatment_descrip = value; }
        }

        public int Id_branch
        {
            get { return id_branch; }
            set { id_branch = value; }
        }

        public int Id_med_report
        {
            get { return id_med_report; }
            set { id_med_report = value; }
        }
        #endregion
    }
}
