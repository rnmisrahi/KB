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

namespace _1.Dataset_and_DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void BindGridview()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Integrated Security=true;Initial Catalog=Northwind");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Categories", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            sda.Update(ds);
            ds.WriteXml(@"d:\temp\x.xml");
            gvUserInfo.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGridview();
        }

        private void btnDataReader_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Integrated Security=true;Initial Catalog=Northwind");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Categories", conn);

            using (SqlDataReader reader = cmd.ExecuteReader()){
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String s = string.Format("ID: {0}. Name: {1}{2}", reader.GetInt32(0), reader.GetString(1), Environment.NewLine);
                        lstReader.Items.Add(s);
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\Temp\x.xml");
            gvUserInfo.DataSource = ds.Tables[0];
        }
    }
}
