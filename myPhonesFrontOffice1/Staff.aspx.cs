using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myPhonesTesting;

public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void ok_Click(object sender, EventArgs e)
    {
        clsStaff staffTest = new clsStaff();
        staffTest.staffId = TextBoxStaffId.Text; 
        staffTest.orderId = TextBoxOrderId.Text;
        staffTest.staffFullName = TextBoxStaffFullName.Text;
        staffTest.staffAddress = TextBoxStaffAddress.Text;
        staffTest.staffJobTitle = TextBoxStaffJobTitle.Text;
        staffTest.StaffJoined = Convert.ToDateTime(TextBoxStaffJoined.Text);

        Session["staffTesting"] = staffTest;
        Response.Redirect("StaffViewer.aspx");
    }
}