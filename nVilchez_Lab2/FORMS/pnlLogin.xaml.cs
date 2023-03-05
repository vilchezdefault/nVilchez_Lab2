using nVilchez_Lab2.DATA;
using nVilchez_Lab2.TOOLS;
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

namespace nVilchez_Lab2.FORMS
{
    /// <summary>
    /// Interaction logic for pnlLogin.xaml
    /// </summary>
    public partial class pnlLogin : Window
    {
        public pnlLogin()
        {
            InitializeComponent();
        }

        private void lblLogingTest_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPassword.Password.ToString().Length > 0)
            {
                clsUser usuario = new clsUser(txtUser.Text, txtPassword.Password.ToString());

                //data transfer object DTO que comunica con la base de datos
                dtoUsuario usu = new dtoUsuario();
                if (usu.RequestLogin(usuario) == true)
                {
                    clsGlobalValue.userLogin = usuario.UserName_prop;
                    pnlAllergies window = new pnlAllergies();
                    window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something its wrong!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the fields USERNAME and PASSWORD");
            }

        }

 
    }
}

