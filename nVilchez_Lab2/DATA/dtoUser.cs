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
                string query = "SELECT USU_USUARIO FROM VETERINARIASOS.dbo.VT_USUARIOS WHERE USU_USUARIO ='"
                    + data.UserName_prop + "' AND USU_CLAVE = '" + data.Password_prop + "'";

                var existe = conn.SQLCargaDataTable(_SQLConnection, query, null);
                if (existe.Rows.Count > 0)
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

