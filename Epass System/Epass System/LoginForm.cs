using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Epass_System
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PRATIK\SQLEXPRESS;Initial Catalog=epass_system;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "login");
                cmd.Parameters.AddWithValue("@register_name", txtName.Text);
                cmd.Parameters.AddWithValue("@register_adhar", Convert.ToInt64(txtAdhar.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);                
                if (dt.Rows[0][0].ToString()=="1")
                {
                    WelcomeUser_Form w = new WelcomeUser_Form();
                    w.Show();                     
                }
                else
                {
                    MessageBox.Show("Invalis Credentials");
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
