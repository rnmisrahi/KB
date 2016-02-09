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

namespace _4a.DataView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Integrated Security=true;Initial Catalog=Northwind");
            string strSQL = "Select * from Categories";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(dt);
            //Console.WriteLine(cb.GetUpdateCommand().CommandText.ToString());
            conn.Close();
            grvDataView.DataSource = ds.Tables[0];
            //grvDataView.DataBind();
        }
    }
}
