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
    public partial class RegisterForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public RegisterForm()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=PRATIK\SQLEXPRESS;Initial Catalog=epass_system;Integrated Security=True");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "insert");
                cmd.Parameters.AddWithValue("@register_name", txtName.Text);
                cmd.Parameters.AddWithValue("@register_mobile", Convert.ToInt64(txtMobile.Text));
                cmd.Parameters.AddWithValue("@register_address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@register_address_code", Convert.ToInt64(txtCityCode.Text));
                cmd.Parameters.AddWithValue("@register_adhar", txtAdhar.Text);
                cmd.Parameters.AddWithValue("@register_age", Convert.ToInt64(txtAge.Text));
                cmd.Parameters.AddWithValue("@register_dob", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@register_city", txtCity.Text);
                int n=cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(txtName.Text+" Registered");
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
