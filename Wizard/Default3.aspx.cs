using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    private static Default_Data mData;// = new Default_Data();

    public static Default_Data WizData3 { get { return mData; } set { mData = value; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            if (PreviousPage.IsValid)
            {
                //mData = (PreviousPage.WizData2 as Default_Data);

                //string lg = mData.LG ? "Loves girls" : "Doesn't love girls";
                //lblPrevious.Text = String.Format("{0} with ID {1} absolutely {2}",
                //mData.StudentName, mData.StudentId, lg);


            }
        }
    }
}