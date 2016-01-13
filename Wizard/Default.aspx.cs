using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private Default_Data mData;// = new Default_Data();

    public Default_Data WizData1 { get { return mData; } set { mData = value; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        //In case it came back from Default2. DOESN'T WORK
        repopulate();
        if (Page.PreviousPage != null) { 
            DropDownList ddlCourse = (Page.PreviousPage.FindControl("ddlCourse") as DropDownList);
            if (ddlCourse != null)
                mData.Course = ddlCourse.SelectedItem.Text;
            //mData = (PreviousPage.WizData2 as Default_Data);
            //populate the 
        }
    }

    private void repopulate()
    {
        if (mData != null)
        {
            txtId.Text = mData.StudentId;
            txtName.Text = mData.StudentName;
            cbLovesGirls.Checked = mData.LG;
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {

    }

    protected void Page_Unload(object sender, EventArgs e)
    {
    }

    protected void Page_Rendered(object sender, EventArgs e)
    {

    }

    protected void Page_BeforeUnload(object sender, EventArgs e)
    {

    }

    private void populateData()
    {
        if (mData == null)//Todo make it a Singleton
            mData = new Default_Data();
        mData.StudentId = txtId.Text;
        mData.StudentName = txtName.Text;
        mData.LG = cbLovesGirls.Checked;
    }

    protected void btnNext_Click(object sender, EventArgs e)
    {
        populateData();
    }

    public TextBox TxtId { get { return txtId; } }

    public TextBox TxtName { get { return txtName; } }

    public CheckBox CBLovesGirls { get { return cbLovesGirls; } }
}