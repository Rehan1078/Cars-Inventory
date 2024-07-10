using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Update : Form

    {
        DataTable dt = new DataTable();
        Databaseclass c = new Databaseclass();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
        public Update()
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
                    pictureBoxUpdate.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
      

        private void buttonupdaterecord_Click(object sender, EventArgs e)
        {
            
          try
            {
                if (!string.IsNullOrEmpty(textBoxmodel1.Text) &&
                    !string.IsNullOrEmpty(textBoxengine1.Text) &&
                    !string.IsNullOrEmpty(textBoxcolor1.Text) &&
                    !string.IsNullOrEmpty(textBoxseatcapa1.Text) &&
                    !string.IsNullOrEmpty(textBoxenginetype1.Text) &&
                    !string.IsNullOrEmpty(textBoxtransmission1.Text) &&
                    !string.IsNullOrEmpty(textBoxMaxspeed1.Text) &&
                    !string.IsNullOrEmpty(textBoxgearbox1.Text))
                {
                    SqlCommand cmd;

                    if (imageurl != null)
                    {
                        // If a new image is selected, update ImagePath
                        cmd = new SqlCommand("UPDATE toyota SET Model = @Model, Engine = @Engine, Color = @Color, SeatingCapacity = @SeatingCapacity, Enginetype = @EngineType, Transmission = @Transmission, MaxSpeed = @MaxSpeed, Gearbox = @GearBox, Imagepath = @ImagePath WHERE Engine = @Engine", conn);
                        cmd.Parameters.AddWithValue("@ImagePath", imageurl);
                    }
                    else
                    {
                        // If no new image is selected, exclude ImagePath from the update
                        cmd = new SqlCommand("UPDATE toyota SET Model = @Model, Engine = @Engine, Color = @Color, SeatingCapacity = @SeatingCapacity, Enginetype = @EngineType, Transmission = @Transmission, MaxSpeed = @MaxSpeed, Gearbox = @GearBox WHERE Engine = @Engine", conn);
                    }

                    conn.Open();

                    cmd.Parameters.AddWithValue("@Model", textBoxmodel1.Text.ToString());
                    cmd.Parameters.AddWithValue("@Engine", textBoxengine1.Text.ToString());
                    cmd.Parameters.AddWithValue("@Color", textBoxcolor1.Text.ToString());
                    cmd.Parameters.AddWithValue("@SeatingCapacity", textBoxseatcapa1.Text.ToString());
                    cmd.Parameters.AddWithValue("@EngineType", textBoxenginetype1.Text.ToString());
                    cmd.Parameters.AddWithValue("@Transmission", textBoxtransmission1.Text.ToString());
                    cmd.Parameters.AddWithValue("@MaxSpeed", textBoxMaxspeed1.Text.ToString());
                    cmd.Parameters.AddWithValue("@GearBox", textBoxgearbox1.Text.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    Clear();
                    
                }
                else
                {
                    MessageBox.Show("Please fill all the details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            }
        public void Clear()
        {
            textBoxmodel1.Text = "";
            textBoxengine1.Text = "";
            textBoxcolor1.Text = "";
            textBoxseatcapa1.Text = "";
            textBoxenginetype1.Text = "";
            textBoxtransmission1.Text = "";
            textBoxMaxspeed1.Text = "";
            textBoxgearbox1.Text = "";
            imageurl = null;
            pictureBoxUpdate.Image = null;
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxsearchfordelete.Text;
            try
            {
                // SqlConnection con = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
                //'" + keyword + "%'
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT VehicleID,Model,Engine,Color ,SeatingCapacity ,EngineType ,Transmission,Maxspeed ," +
                    "Gearbox FROM toyota WHERE vehicleid LIKE '%" + keyword + "%' OR Model LIKE '%" + keyword + "%' OR engine LIKE '%" + keyword + "%'" +
                    " OR color LIKE '%" + keyword + "%' OR enginetype LIKE '%" + keyword + "%'", conn);

                DataTable datat = new DataTable();
                cmd.Fill(datat);
                dataGridViewsearchfordelete.DataSource = datat;
              
            }
            catch(Exception ex) { }
            finally {  }
        }

        private void Update_Load(object sender, EventArgs e)
        {
           // DataTable d = new DataTable();
            DataTable d = c.select();
            dataGridViewsearchfordelete.DataSource = d;
        }

        private void dataGridViewsearchupdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewsearchfordelete.Rows[e.RowIndex].Cells["VehicleID"].FormattedValue);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("Select ImagePath from toyota where VehicleID = '" + id + "'", conn);
                string img = sqlCommand.ExecuteScalar().ToString();
                pictureBoxUpdate.Image = Image.FromFile(img);

                int rowIndex = e.RowIndex;
                //at 0 index the vehicle id
                textBoxmodel1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxengine1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxcolor1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[3].Value.ToString();
                textBoxseatcapa1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[4].Value.ToString();
                textBoxenginetype1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[5].Value.ToString();
                textBoxtransmission1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[6].Value.ToString();
                textBoxMaxspeed1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[7].Value.ToString();
                textBoxgearbox1.Text = dataGridViewsearchfordelete.Rows[rowIndex].Cells[8].Value.ToString();
                pictureBoxUpdate.Image = Image.FromFile(img);
                // textBoxgearbox.Text = dataViewshowroom.Rows[rowIndex].Cells[8].Value.ToString();

            }
            catch (Exception ex) { }
            finally { conn.Close(); }
        }

        private void dataGridViewsearchfordelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
