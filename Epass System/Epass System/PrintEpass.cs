using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Epass_System
{
    public partial class PrintEpass : Form
    {

        ReportDocument crypt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=PRATIK\SQLEXPRESS;Initial Catalog=epass_system;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public PrintEpass()
        {
            InitializeComponent();
        }

        public int registerNo { get; set; }

        private void PrintEpass_Load(object sender, EventArgs e)
        {
            DataTable dt = getData();
            showReport(dt);
        }

        private void showReport(DataTable dt)
        {
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load("CrystalReport1.rpt");
            rdoc.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rdoc;
        }

        private DataTable getData()
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("pr_print", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@register_no", this.registerNo);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }catch(Exception ee)
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
