using nVilchez_Lab2.DATABASE;
using System;
using System.Windows;


namespace nVilchez_Lab2.DATA
{
    public class dtoUsuario
    {
        private ConnSQL conn = new ConnSQL();//to create query
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool RequestLogin(clsUser data)
        {
            try
            {
                string query = "SELECT username FROM petSos.dbo.tb_users WHERE username ='"
                    + data.UserName_prop + "' AND passwords = '" + data.Password_prop + "'";

                var exist = conn.SQLCargaDataTable(_SQLConnection, query, null);
                if (exist.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }

}

