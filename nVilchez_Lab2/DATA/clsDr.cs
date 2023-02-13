using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_lab1.DATA
{/// <summary>
 ///   Atributos: Son aquellos que van privados
 ///   Constructores vacíos y de sobrecarga
 ///   Funciones y Procedimientos: imprimir los datos
 ///   Métodos: Los que van públicos, set y gets 
 /// </summary>


    public class clsDr
    {
        #region Attributtes
        private int id_dr;
        private int code_med;
        private string full_name;
        private string last_names;
        private string personal_id;

        #endregion Attibuttes   
        #region constructors
       public clsDr()
        {
            this.id_dr = 0;
            this.code_med = 0;
            this.full_name = "";
            this.last_names= "";
            this.personal_id = "";
        }

        public clsDr(int id_dr, int code_med, string full_name, string last_names, string personal_id)
        {
            this.id_dr = id_dr;
            this.code_med = code_med;
            this.full_name = full_name;
            this.last_names = last_names;
            this.personal_id = personal_id;
        }
        #endregion constructors
        #region functions or procedures
        public string printData()
        {
            string data = "";
            data = "Name" +this.full_name + this.last_names + "\n" +
                "ID medical collage" + this.code_med + "\n" +
                "PersonalID" + this.personal_id + "\n" +
                "ID DR" + this.id_dr + "\n";
            return data;
        }
        #endregion functions N procedures
        #region Get & Set
        public string Personal_id
        {
            get { return personal_id; }
            set { personal_id = value; }
        }
        public string Last_names
        {
            get { return last_names.ToUpper(); }
            set { last_names = value; }
        }
        public string Full_name
        {
            get { return full_name.ToUpper(); }
            set { full_name = value; }
        }
        public int Code_med
        {
            get { return code_med; }
            set { code_med = value; }
        }
        public int Id_dr
        {
            get { return id_dr; }
            set { id_dr = value; }
        }
        #endregion

    }
}

