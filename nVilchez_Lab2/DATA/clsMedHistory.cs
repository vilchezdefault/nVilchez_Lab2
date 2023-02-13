using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_lab1.DATA
{
    public class clDocu
    {
        #region Attributes

        private int internal_id, id_client;
        private string firstName;
        private string second_name;
        private string last_name;
        private string second_lastname;
        private DateTime dateBirth;
        private char gender;
        private string email;
        private string phone_number;
        private string allergies;
        #endregion Attributes

        #region builders
        public clDocu()
        {
            this.internal_id = 0;
            this.firstName = "";
            this.second_name = "";
            this.last_name = "";
            this.second_lastname = "";
            this.dateBirth= Convert.ToDateTime("05/02/2023");
            this.gender = '*';
            this.email = "";
            this.phone_number = "";
            this.allergies = "";
            this.id_client = 0;
        }

        public clDocu(int internal_id, int id_client, string firstName, string second_name, string last_name, string second_lastname, DateTime dateBirth, char gender, string email, string phone_number, string allergies)
        {
            this.internal_id = internal_id;
            this.id_client = id_client;
            this.firstName = firstName;
            this.second_name = second_name;
            this.last_name = last_name;
            this.second_lastname = second_lastname;
            this.dateBirth = dateBirth;
            this.gender = gender;
            this.email = email;
            this.phone_number = phone_number;
            this.allergies = allergies;
        }
        #endregion builders

        #region functions N procedures

        public string printData()
        {
            string data = "";
            data = "Name" + this.firstName + this.last_name + this.second_lastname + "\n" +
                    "ID" + this.id_client + "\n" +
                    "Email" + this.email + "\n" +
                    "phone" + this.phone_number + "\n" +
                    "Gender" + this.gender + this.dateBirth + "\n" +
                    "Allergies" + this.allergies + "\n";
            return data;
        }

        #endregion functions N procedures

        #region Gets N Sets
        public int Internal_id
        {
            set { internal_id = value; }
            get { return internal_id; }
        }
        public int id_clientI        {
            set { id_client = value; }
            get { return id_client; }
        }
        public String FirstName
        {
            set { firstName = value.ToUpper(); }
            get { return firstName; }
        }
        public String Second_name
        {
            set { second_name = value.ToUpper(); }
            get { return second_name; }
        }
        public String Last_name
        {
            set { last_name = value.ToUpper(); }
            get { return last_name; }
        }
        public String Second_lastname
        {
            set { second_lastname = value.ToUpper(); }
            get { return second_lastname; }
        }
        public DateTime DateBirth
        {
            set { dateBirth = value; }
            get { return dateBirth; }
        }
        public char Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public String Email
        {
            set { email = value; }
            get { return email; }
        }
        public String Phone_number
        {
            set { phone_number = value; }
            get { return phone_number; }
        }
        public String Allergies
        {
            set { allergies = value; }
            get { return allergies; }
        }
        #endregion
    }
}
