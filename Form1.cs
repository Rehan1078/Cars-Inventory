using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            Customdesign();
        }
        
        private void Customdesign()
        {
            panelsettings.Visible = false;

        }
        private void hidesubmenu()
        {
            if (panelsettings.Visible == true)
                panelsettings.Visible = false;


        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }

            else
            {

                submenu.Visible = false;
            }
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(childform);
            FormPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            openchildform(new Home());
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            openchildform(new Home());
        }

        private void btshowroom_Click(object sender, EventArgs e)
        {
            openchildform(new Showroom()); 
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            openchildform(new Add());
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //  openchildform(new Update());
            showsubmenu(panelsettings);
        }

        private void btAboutus_Click(object sender, EventArgs e)
        {
            openchildform(new Aboutus());
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login again = new Login();
            this.Hide();
            again.Show();
        }

        private void btupdatesettings_Click(object sender, EventArgs e)
        {
            openchildform(new Update());
        }

        private void btdeletesettings_Click(object sender, EventArgs e)
        {
            openchildform(new Delete());
        }

        private void btaboutus_Click_1(object sender, EventArgs e)
        {
            openchildform(new Aboutus());
        }

        private void btlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
