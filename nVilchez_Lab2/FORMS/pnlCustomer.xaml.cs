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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void txtIdCustomer_Copy7_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    TOOLS.clsChs.onlyLetters(e);
        //}
    }
}
