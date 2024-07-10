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
    public partial class Showroom : Form
    {
        Databaseclass c = new Databaseclass();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
        public Showroom()
        {
            InitializeComponent();
        }

        private void Showroom_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            dataViewshowroom.DataSource = dt;
        }

        private void dataViewshowroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int id = Convert.ToInt32(dataViewshowroom.Rows[e.RowIndex].Cells["VehicleID"].FormattedValue);
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("Select ImagePath from toyota where VehicleID = '" + id + "'", conn);
                string img = sqlCommand.ExecuteScalar().ToString();
                pictureShowroomcar.Image = Image.FromFile(img);

                int rowIndex = e.RowIndex;

                textBoxvehicleid.Text = dataViewshowroom.Rows[rowIndex].Cells[0].Value.ToString();
                textBoxModel.Text = dataViewshowroom.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxEngine.Text = dataViewshowroom.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxcolor.Text = dataViewshowroom.Rows[rowIndex].Cells[3].Value.ToString();
                textBoxseatcapa.Text = dataViewshowroom.Rows[rowIndex].Cells[4].Value.ToString();
                textBoxenginetype.Text = dataViewshowroom.Rows[rowIndex].Cells[5].Value.ToString();
                textBoxtransmission.Text = dataViewshowroom.Rows[rowIndex].Cells[6].Value.ToString();
                textBoxmaxspeed.Text = dataViewshowroom.Rows[rowIndex].Cells[7].Value.ToString();
                textBoxgearbox.Text = dataViewshowroom.Rows[rowIndex].Cells[8].Value.ToString();

            }
            catch (Exception ex) { }
            finally { conn.Close(); }
        }

    }
}
