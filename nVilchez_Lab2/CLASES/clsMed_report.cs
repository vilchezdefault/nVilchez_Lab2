using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_lab1.DATA
{
    public class clsMed_report
    {
        #region Attributtes
        private int id_med_report;
        private int id_customer;
        private DateTime date_appoint;
        private string symptoms;
        private string diagnostic;
        #endregion Attributtes

        #region Constructors
        public clsMed_report()
        {
            this.id_med_report = 0;
            this.id_customer= 0;
            this.date_appoint = new DateTime();
            this.symptoms = "";
            this.diagnostic = "";
        }

        public clsMed_report(int id_med_report, int id_customer, DateTime date_appoint, string symptoms, string diagnostic)
        {
            this.id_med_report = id_med_report;
            this.id_customer = id_customer;
            this.date_appoint = date_appoint;
            this.symptoms = symptoms;
            this.diagnostic = diagnostic;
        }

        #endregion Constructors

        #region functions or procedures

        public string printData()
        {
            string data = "";
            data = "ID Customer" + this.id_customer + "\n" +
                    "ID Report" + this.id_med_report + "\n" +
                    "Last check" + this.date_appoint + "\n" + 
                    "Symptoms" + this.symptoms + "\n" + 
                    "Diagnostic" + this.diagnostic + "\n"; 
            return data;
        }

        #endregion functions or procedures

        #region Gets & Sets
        public string Diagnostic
        {
            get { return diagnostic; }
            set { diagnostic = value; }
        }

        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }

        public DateTime Date_appoint
        {
            get { return date_appoint; }
            set { date_appoint = value; }
        }


        public int Id_customer
        {
            get { return id_customer; }
            set { id_customer = value; }
        }

        public int Id_med_report
        {
            get { return id_med_report; }
            set { id_med_report = value; }
        }
        #endregion
    }
}
