using nVilchez_Lab2.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace nVilchez_Lab2.DATA
{
    public class dtoCustomer
    {
        private ConnSQL conn = new ConnSQL();//To do querys SQL
        private string _SQLConnection = Conn.GetConnectionStrings();

        //QUERY
        public bool saveCustomer(clsCustomer DATA)
        {
            try
            {
                string SAVE = "INSERT INTO petSos.dbo.LAB_CUSTOMER VALUES ('" + DATA.Kind_id + "', '" + DATA.Personal_id + "', '" + DATA.Customer_name + "', '" + DATA.Last_name + "', '" +
                                DATA.Second_lastname + "', '" + DATA.Date_birth + "', '" + DATA.Weight + "', '" + DATA.Gender + "', '" + DATA.Phone_number + "', '" + DATA.Email +
                                "', '" + DATA.Status + "', '" + DATA.AddBy+ "', '" + DATA.DateAdd + "',null,null);" ;

                conn.SQLExecuteCmm(_SQLConnection, SAVE);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }
        /// <summary>
        /// Function to See all info from database
        /// </summary>
        /// <param name="txtKind_id"></param>
        /// <param name="txtPersonal_id"></param>
        /// <param name="txtCustomer_name"></param>
        /// <param name="txtLastname"></param>
        /// <param name="txtSecondLastName"></param>
        /// <param name="dtpDateBirth"></param>
        /// <param name="txtWeight"></param>
        /// <param name="txtGender"></param>
        /// <param name="txtPhone"></param>
        /// <param name="txtEmail"></param>
        /// <param name="ckStatus"></param>

        public void seeCustomersId(TextBox txtKind_id,TextBox txtPersonal_id,TextBox txtCustomer_name,TextBox txtLastname,TextBox txtSecondLastName,
                                   DatePicker dtpDateBirth,Decimal txtWeight, Char txtGender, TextBox txtPhone, TextBox txtEmail,CheckBox ckStatus,clsCustomer cust)
        {
            string query = "SELECT CUS_KIND_ID ,CUS_PERSONAL_ID,CUS_CUSTOMER_NAME,CUS_LAST_NAME,CUS_SECOND_LASTNAME,CUS_DATE_BIRTH,CUS_WEIGHT,CUS_GENDER," +
                            "CUS_PHONE_NUMBER,CUS_EMAIL,CUS_STATUS,CUS_AddBy,CUS_DateAdd,CUS_UpdateBy,CUS_DateUpdate FROM petSos.dbo.LAB_CUSTOMER WHERE CUS_PERSONAL_ID ='" + cust.Personal_id + "';"; 



            var data = conn.SQLCargaDataTable(_SQLConnection, query,null);
            if (data.Rows.Count>0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    txtKind_id.Text = data.Rows[i].ItemArray[1].ToString();
                    txtPersonal_id.Text = data.Rows[i].ItemArray[2].ToString();
                    txtCustomer_name.Text = data.Rows[i].ItemArray[3].ToString();
                    txtLastname.Text = data.Rows[i].ItemArray[4].ToString();
                    txtSecondLastName.Text = data.Rows[i].ItemArray[5].ToString();
                    dtpDateBirth.Text = data.Rows[i].ItemArray[6].ToString();
                    //txtWeight.Text = data.Rows[i].ItemArray[6].ToString();
                    //txtGender.Text = data.Rows[i].ItemArray[6].ToString();
                    txtPhone.Text = data.Rows[i].ItemArray[6].ToString();
                    txtEmail.Text = data.Rows[i].ItemArray[6].ToString();
                    //ckStatus.Text = data.Rows[i].ItemArray[6].ToString();

                }
            }


        }
                                                          
    }
}