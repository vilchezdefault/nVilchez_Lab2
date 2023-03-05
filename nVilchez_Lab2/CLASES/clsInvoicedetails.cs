using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nVilchez_lab1.DATA
{
    /// <summary>
    ///   Atributos: Son aquellos que van privados
    ///   Constructores vacíos y de sobrecarga
    ///   Funciones y Procedimientos: imprimir los datos
    ///   Métodos: Los que van públicos, set y gets 
    /// </summary> r
    public class clsInvoicedetails
    {
        #region attributtes
        private int id_bill;
        private int id_branch;
        private int amount;
        private decimal iva;
        private decimal check;

        #endregion attributtes

        #region constructors 
        public clsInvoicedetails()
        {
            this.id_bill = 0;
            this.id_branch = 0;
            this.amount = 0;
            this.iva = 0;
            this.check = 0;
        }
        public clsInvoicedetails(int id_bill,int id_branch, int amount, decimal iva, decimal check)
        {
            this.id_bill = id_bill;
            this.id_branch = id_branch; 
            this.amount = amount;
            this.iva = iva;
            this.check = check;
        }
        #endregion constructors

        #region procedure or function

        public string printData()
        {
            string data = "";
            data = "ID Bill" + this.id_bill + "\n" +
                    "Branches" + this.id_branch + "\n" +
                    "Quantity of products" + this.amount + "\n" +
                    "Total to be paid" + this.check + "\n" +
                    "IVA" + this.iva + "\n";
            return data;
        }
        #endregion procedure or function 

        #region Sets & Gets
        public int Id_bill
        {
            set { id_bill = value; }
            get { return id_bill; }
        }
        public int Id_branch
        {
            set { id_branch = value; }
            get { return id_branch; }
        }
        public int Aamount
        {
            set { amount = value; }
            get { return amount; }
        }
        public decimal Iva
        {
            set { iva = value; }
            get { return iva; }
        }
        public decimal Check
        {
            set { check = value; }
            get { return check; }
        }
        #endregion Sets & Gets

    }
}
