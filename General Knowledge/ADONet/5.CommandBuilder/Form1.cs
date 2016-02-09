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

namespace _5.CommandBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommandBuilder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Integrated Security=true;Initial Catalog=Northwind");
            string strSQL = "Select * from Categories";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            SqlCommandBuilder cb = new SqlCommandBuilder(dt);
            Console.WriteLine(cb.GetUpdateCommand().CommandText.ToString());
            conn.Close();
            grvDataView.DataSource = ds.Tables[0];
            //grvDataView.DataBind();

        }

        private void btnComandBuilder2_Click(object sender, EventArgs e)
        {
            String sql;
            //CommandBuilder doesn't support multiple table queries
            sql = @"Select Orders.OrderDate, Customers.CompanyName from Orders ";
            sql+="Join Customers On Orders.CustomerID=Customers.CustomerID";
            sql = @"SELECT* FROM Categories";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Integrated Security=true;Initial Catalog=Northwind"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    //This is supported only against single tables.
                    using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                    {
                        builder.QuotePrefix = "[";
                        builder.QuoteSuffix = "]";
                        Console.WriteLine(builder.GetUpdateCommand().CommandText);
                        Console.WriteLine(builder.GetInsertCommand().CommandText);
                        Console.WriteLine(builder.GetDeleteCommand().CommandText);
                    }
                }
            }
        }
    }
}
