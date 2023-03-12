using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace nVilchez_Lab2.DATA
{
    public class clsCustomer
    {
        #region Attributes
        private int id_customer;
        private string kind_id;
        private string personal_id;
        private string customer_name;
        private string last_name;
        private string second_lastname;
        private DateTime date_birth;
        private decimal weight;
        private char gender;
        private string phone_number;
        private string email;
        private string status;
        private string addBy;
        private DateTime dateAdd;
        private string update_by;
        private DateTime date_update;

        #endregion
        #region Constructors
        public clsCustomer()
        {
            this.id_customer = 0;
            this.kind_id = "";
            this.personal_id= "";
            this.customer_name = "";
            this.last_name = "";
            this.second_lastname = "";
            this.date_birth = new DateTime();
            this.weight= 0;
            this.gender = '*';
            this.phone_number = "";
            this.email = "";
            this.status = "";
            this.addBy = "";
            this.dateAdd = new DateTime();
            this.update_by = "";
            this.date_update = new DateTime();
        }
        public clsCustomer(int id_customer, string kind_id, string personal_id, string customer_name, string last_name, string second_lastname, DateTime date_birth, decimal weight, char gender, string phone_number, string email)
        {
            this.id_customer = id_customer;
            this.kind_id = kind_id;
            this.personal_id = personal_id;
            this.customer_name = customer_name;
            this.last_name = last_name;
            this.second_lastname = second_lastname;
            this.date_birth = date_birth;
            this.weight = weight;
            this.gender = gender;
            this.phone_number = phone_number;
            this.email = email;
        }

        public clsCustomer(string kind_id, string personal_id, string customer_name, string last_name, string second_lastname, DateTime date_birth, decimal weight, char gender, string phone_number, string email, string status,string addBy,DateTime dateAdd)
        {

            this.kind_id = kind_id;
            this.personal_id = personal_id;
            this.customer_name = customer_name;
            this.last_name = last_name;
            this.second_lastname = second_lastname;
            this.date_birth = date_birth;
            this.weight = weight;
            this.gender = gender;
            this.phone_number = phone_number;
            this.email = email;
            this.status = status;
            this.addBy = addBy;
            this.dateAdd = dateAdd;
            

        }
        #endregion Constructors

        #region functions or procedure
        public string printData()
        {
            string data = "";
            data = "Id customer" + this.id_customer + "\n" +
                    "Kind of ID" + this.kind_id + "\n" +
                    "Personal ID" + this.Personal_id + "\n" +
                    "Name" + this.customer_name + "\n" +
                    "Last names" + this.last_name + this.second_lastname + "\n" +
                    "Weight" + this.weight + "\n" +
                    "Gender" + this.gender + "\n" +
                    "Phone" + this.phone_number + "\n" +
                    "Email" + this.email + "\n" +
                    "Status" + this.status + "\n" +
                    "Add By" + this.addBy + "\n" +
                    "Date when save" + this.dateAdd + "\n" +
                    "Update By" + this.update_by + "\n" +
                    "Update Date" + this.date_update + "\n" +
                    "";
            return data;
        }
        #endregion
        #region Sets & Gets

        public string Update_by
        {
            get { return update_by; }
            set { update_by = value; }
        }

        public DateTime DateAdd
        {
            get { return dateAdd; }
            set { dateAdd = value; }
        }

        public string AddBy
        {
            get { return addBy; }
            set { addBy = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Email

        {
            get { return email; }
            set { email = value; }
        }

        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public DateTime Date_birth
        {
            get { return date_birth; }
            set { date_birth = value; }
        }

        public string Second_lastname
        {
            get { return second_lastname; }
            set { second_lastname = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Customer_name
        {
            get { return customer_name; }
            set { customer_name = value; }
        }

        public string Personal_id
        {
            get { return personal_id; }
            set { personal_id = value; }
        }

        public string Kind_id
        {
            get { return kind_id; }
            set { kind_id = value; }
        }

        public int Id_customer
        {
            get { return id_customer; }
            set { id_customer = value; }
        }
        public DateTime Date_update
        {
            get { return date_update; }
            set { date_update = value; }
        }


        #endregion
    }
}