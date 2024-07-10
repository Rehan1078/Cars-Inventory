using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    
    public partial class Login : Form
    {
        MainPage m = new MainPage();
        Thread th;
        
        public Login()
        {
            InitializeComponent();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;
           
                if (username == "admin" && password == "admin")
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();


                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
               
            
        }

        private void opennewform()
        {
            Application.Run(new MainPage());
        }
    }
}
