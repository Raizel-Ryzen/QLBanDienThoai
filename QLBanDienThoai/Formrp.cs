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
using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Server;

namespace QLBanDienThoai
{

    public partial class Formrp : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\ql_bandienthoai.mdf
            ;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlCon = null;
        public Formrp()
        {
            InitializeComponent();
        }

        private void Formrp_Load(object sender, EventArgs e)
        {
            if (sqlCon == null) ;
            {
                sqlCon = new SqlConnection(strCon);
            }
            string sql = "select * from KHACHHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tk");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanDienThoai.Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["tk"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}