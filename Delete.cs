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
    public partial class Delete : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
        DataTable dt = new DataTable();
        Databaseclass c = new Databaseclass();
        public Delete()
        {
            InitializeComponent();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxsearch.Text;
            try
            {
                // SqlConnection con = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
                // '%" + keyword + "%'
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT VehicleID,Model,Engine,Color ,SeatingCapacity ,EngineType ,Transmission,Maxspeed ,Gearbox FROM toyota WHERE vehicleid LIKE '%" + keyword + "%' OR Model LIKE '%" + keyword + "%' OR engine LIKE '%" + keyword + "%' OR color LIKE '%" + keyword + "%' OR enginetype LIKE '%" + keyword + "%'", conn);
                DataTable datat = new DataTable();
                cmd.Fill(datat);
                dataviewdelete.DataSource = datat;
            }
            catch (Exception ex) { }
            finally { }
        }

        private void dataGridViewsearchupdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataviewdelete.Rows[e.RowIndex].Cells["VehicleID"].FormattedValue);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("Select ImagePath from toyota where VehicleID = '" + id + "'", conn);
                string img = sqlCommand.ExecuteScalar().ToString();
                pictureBoxUpdate.Image = Image.FromFile(img);

                int rowIndex = e.RowIndex;
                //  At 0 Index  -->  (Vehicle ID)
                textBoxmodel1.Text = dataviewdelete.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxengine1.Text = dataviewdelete.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxcolor1.Text = dataviewdelete.Rows[rowIndex].Cells[3].Value.ToString();
                textBoxseatcapa1.Text = dataviewdelete.Rows[rowIndex].Cells[4].Value.ToString();
                textBoxenginetype1.Text = dataviewdelete.Rows[rowIndex].Cells[5].Value.ToString();
                textBoxtransmission1.Text = dataviewdelete.Rows[rowIndex].Cells[6].Value.ToString();
                textBoxMaxspeed1.Text = dataviewdelete.Rows[rowIndex].Cells[7].Value.ToString();
                textBoxgearbox1.Text = dataviewdelete.Rows[rowIndex].Cells[8].Value.ToString();

                pictureBoxUpdate.Image = Image.FromFile(img);



                //comboBoxmodel.SelectedItem = comboBoxmodel.Text;
                //comboBoxengine.SelectedItem = comboBoxengine.Text;
                //comboBoxColor.SelectedItem = comboBoxColor.Text;
                //comboBoxSeatcapa.SelectedItem = comboBoxSeatcapa.Text;
                //comboBoxenginetype.SelectedItem = comboBoxenginetype.Text;
                //comboBoxTrasnmission.SelectedItem = comboBoxTrasnmission.Text;
                //comboBoxmaxspeed.SelectedItem = comboBoxmaxspeed.Text;
                //comboBoxGearBox.SelectedItem = comboBoxGearBox.Text;

            }
            catch (Exception ex) { }
            finally { conn.Close(); }
        }

        private void buttondeleterecord_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM toyota WHERE engine = @Engine", conn);
                cmd.Parameters.AddWithValue("@Engine", textBoxengine1.Text.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                Clear();

            }
            catch(Exception ex) { }
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
            //imageurl = null;
            pictureBoxUpdate.Image = null;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            dataviewdelete.DataSource = dt;
        }

        private void dataviewdelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
