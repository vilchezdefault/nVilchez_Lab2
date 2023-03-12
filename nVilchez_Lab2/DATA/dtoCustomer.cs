using nVilchez_Lab2.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
    }
}