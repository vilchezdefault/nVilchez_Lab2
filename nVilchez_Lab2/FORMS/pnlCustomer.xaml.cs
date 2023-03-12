using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using nVilchez_Lab2.DATA;
using nVilchez_Lab2.TOOLS;

namespace nVilchez_Lab2.FORMS
{
    /// <summary>
    /// Interaction logic for pnlCustomer.xaml
    /// </summary>
    public partial class pnlCustomer : Window
    {
        public pnlCustomer()
        {
            InitializeComponent();
        }



        private void txtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TOOLS.clsChs.onlyLetters(e);
        }

        private void btnSave1_Click(object sender, RoutedEventArgs e)
        {
            string status;
            if (txtKind_id.Text.Length > 0 && txtPersonal_id.Text.Length > 0 && txtCustomer_name.Text.Length > 0 && txtLastname.Text.Length > 0 &&
                txtSecondLastName.Text.Length >0 && dtpDateBirth.SelectedDate !=null)
            {
                if (ckStatus.IsChecked == true)
                {
                    status = "A";
                }
                else
                {
                    status = "I";
                }



                clsCustomer customer = new clsCustomer(txtKind_id.Text, txtPersonal_id.Text, txtCustomer_name.Text, txtLastname.Text, txtSecondLastName.Text,
                                                          dtpDateBirth.SelectedDate.Value.Date,Convert.ToDecimal(txtWeight.Text),Char.Parse(txtGender.Text),
                                                          txtPhone.Text,txtEmail.Text,status,TOOLS.clsGlobalValue.userLogin,DateTime.Now);


                dtoCustomer cust = new dtoCustomer();
                if (cust.saveCustomer(customer) == true)
                {
                    MessageBox.Show("Save complete!");
                }
                else
                {
                    MessageBox.Show("Wrong Data!");

                }
            }
            else
            {
                MessageBox.Show("You need fo fill all");
            }
        }

        private void rdtSaveCustomer_Checked(object sender, RoutedEventArgs e)
        {
            if(rdtSaveCustomer.IsPressed)
            {
                txtMode.Text = "Insertar";
            }
        }

    }
}
