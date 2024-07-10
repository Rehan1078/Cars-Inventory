using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Add : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
        public Add()
        {
            InitializeComponent();
        }
        string imageurl = null;
        private void btUpload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageurl = ofd.FileName;
                    pictureBoxbrowsing.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void buttonAddrecord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxmodel.Text) &&
                   !string.IsNullOrEmpty(comboBoxengine.Text) &&
                   !string.IsNullOrEmpty(comboBoxColor.Text) &&
                   !string.IsNullOrEmpty(comboBoxSeatcapa.Text) &&
                   !string.IsNullOrEmpty(comboBoxenginetype.Text) &&
                   !string.IsNullOrEmpty(comboBoxTrasnmission.Text) &&
                   !string.IsNullOrEmpty(comboBoxmaxspeed.Text) &&
                   !string.IsNullOrEmpty(comboBoxGearBox.Text))
            {// insert into toyota(Model, Engine, Color, SeatingCapacity, EngineType, Transmission, MaxSpeed, GearBox, ImagePath) values(
                try
                {

                    SqlCommand cmd = new SqlCommand("Insert into toyota(Model, Engine, Color, SeatingCapacity, EngineType, Transmission, MaxSpeed, GearBox, ImagePath) values(@Model ,@Engine ,@Color ,@SeatingCapacity , @EngineType ,@Transmission ,@MaxSpeed ,@GearBox ,@ImagePath)", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("Model", comboBoxmodel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Engine", comboBoxengine.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Color", comboBoxColor.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("SeatingCapacity", comboBoxSeatcapa.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("EngineType", comboBoxenginetype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Transmission", comboBoxTrasnmission.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("MaxSpeed", comboBoxmaxspeed.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("GearBox", comboBoxGearBox.SelectedItem.ToString());





                    cmd.Parameters.AddWithValue("ImagePath", imageurl);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted");
                    Clear();
                }
                catch (Exception ex) { }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Fill all the details");
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
        
        public void Clear()
        {
            comboBoxmodel.Text = "";
            comboBoxengine.Text = "";
            comboBoxColor.Text = "";
            comboBoxSeatcapa.Text = "";
            comboBoxenginetype.Text = "";
            comboBoxTrasnmission.Text = "";
            comboBoxmaxspeed.Text = "";
            comboBoxGearBox.Text = "";
            imageurl = null;
            pictureBoxbrowsing.Image = null;
        }
    }
}
