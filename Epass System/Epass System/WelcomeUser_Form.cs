using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Epass_System
{
    public partial class WelcomeUser_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PRATIK\SQLEXPRESS;Initial Catalog=epass_system;Integrated Security=True");
        
        public WelcomeUser_Form()
        {
            InitializeComponent();           
        }

       private void WelcomeUser_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void bindData()
        {
            con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "viewOne");               
                cmd.Parameters.AddWithValue("@register_name",txtName.Text);
                cmd.Parameters.AddWithValue("@register_adhar",txtAdhar.Text);               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count>0)
                {
                    dataGridView1.DataSource = ds.Tables[0]; 
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void comboCityFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnGetDetails_Click_1(object sender, EventArgs e)
        {
            bindData();
        }

        private int getregisterNo()
        {
            return int.Parse(txtRegNo.Text);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyformFill();
            PrintEpass ep = new PrintEpass();
            ep.registerNo = getregisterNo();
            ep.Show();
        }

        private void applyformFill()
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_travel_info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "insert");
                cmd.Parameters.AddWithValue("@journey_date", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@city_from", (comboCityFrom.Text).ToString());
                cmd.Parameters.AddWithValue("@city_to", (comboToCity.Text).ToString());
                cmd.Parameters.AddWithValue("@number_of_passanger",Convert.ToInt64(comboNoOfPassangers.Text).ToString());
                cmd.Parameters.AddWithValue("@district_from", (comboDistrictFrom.Text).ToString());
                cmd.Parameters.AddWithValue("@district_to", (comboToDistrict.Text).ToString());
                cmd.Parameters.AddWithValue("@vehical_no", txtVehicleNumber.Text);
                cmd.Parameters.AddWithValue("@driving_licence", txtDrivingLicance.Text);
                cmd.Parameters.AddWithValue("@vehicle_model", txtModel.Text);
                cmd.Parameters.AddWithValue("@register_no", Convert.ToInt64(txtRegNo.Text));
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Applied Successfully!!");
                }
                else
                {
                    MessageBox.Show("Cant Insert");
                }
               
            }
            catch (Exception ee)
            {
                throw ee;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
