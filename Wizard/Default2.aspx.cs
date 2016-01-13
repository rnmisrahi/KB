using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private static Default_Data mData;// = new Default_Data();

    public static Default_Data WizData2 { get { return mData; } set { mData = value; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            if (PreviousPage.IsValid)
            {
                mData = (PreviousPage.WizData1 as Default_Data);

                //TextBox txtId = (PreviousPage.TxtId as TextBox);
                //TextBox txtName = (PreviousPage.TxtName as TextBox);
                //CheckBox cbLG = (PreviousPage.CBLovesGirls as CheckBox);
                //string lg = cbLG.Checked ? "Loves girls" : "Doesn't love girls";
                //lblDefault.Text = String.Format("{0} with ID {1} absolutely {2}",
                //    txtName.Text, txtId.Text, lg);

                string lg = mData.LG ? "Loves girls" : "Doesn't love girls";
                lblDefault.Text = String.Format("{0} with ID {1} absolutely {2}",
                mData.StudentName, mData.StudentId, lg);

            }
        }
    }//PageLoad

    private void populateData()
    {
        if (mData == null)
            mData = new Default_Data();
        mData.Course = ddlCourse.SelectedItem.Text;
        mData.Hebrew = cbHebrew.Checked;
    }

    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        populateData();
    }

    protected void btnNext_Click(object sender, EventArgs e)
    {
        populateData();
        //Response.Redirect("Default3.aspx");
    }
}