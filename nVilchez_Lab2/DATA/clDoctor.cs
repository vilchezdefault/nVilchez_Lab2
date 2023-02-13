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


    public class clDoctor
    {
        #region Attributes
        private int id_DrMed;
        private string first_name, second_name, last_name, second_lastname, caption_medicine, dose, how_to, symptoms;
        #endregion Attibutes

        #region Builders
        public clDoctor()
        {
            this.id_DrMed = 0;
            this.first_name = "";
            this.second_name = "";
            this.caption_medicine= " ";
            this.dose= " "; 
            this.how_to= " ";   
            this.symptoms= " ";  
        }

        public clDoctor(int id_DrMed, string first_name, string second_name, string last_name, string second_lastname, string caption_medicine, string dose, string how_to, string symptoms)
        {
            this.id_DrMed = id_DrMed;
            this.first_name = first_name;
            this.second_name = second_name;
            this.last_name = last_name;
            this.second_lastname = second_lastname;
            this.caption_medicine = caption_medicine;
            this.dose = dose;
            this.how_to = how_to;
            this.symptoms = symptoms;
        }
        #endregion builders

        #region functions N procedures
        public string printData()
        {
            string data = "";
            data = "Name" + this.first_name + this.last_name + this.second_lastname + "\n" +
                "ID medical collage" + this.id_DrMed + "\n" +
                "How to ingest" + this.how_to + "\n" + "\n" +
                "Dose" + this.dose + "\n" +
                "Symptoms" + this.symptoms + "\n";
            return data;
        }
        #endregion functions N procedures
        #region Get N set
        public int Id_DrMed
        {
            set { id_DrMed = value; }
            get { return id_DrMed; }
        }
        public String First_name    
        {
            set { first_name = value.ToUpper(); }
            get { return first_name; }
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
        public String Caption_medicine
        {
            set { caption_medicine = value.ToUpper(); }
            get { return caption_medicine; }
        }
        public String Dose
        {
            set { dose = value.ToUpper(); }
            get { return dose; }
        }
        public String How_to
        {
            set { how_to = value.ToUpper(); }
            get { return how_to; }
        }
        public String Symptoms
        {
            set { symptoms = value.ToUpper(); }
            get { return symptoms; }
        }
        #endregion

    }
}

