using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staffTesting = new clsStaff();
        staffTesting = (clsStaff)Session["staffTesting"];
        Response.Write(staffTesting.staffFullName);
    }

    protected void ok_Click(object sender, EventArgs e)
    {
        clsStaff staffTesting = new clsStaff();
        staffTesting.staffFullName = TextBoxStaffFullName.Text;
        staffTesting.staffPhoneNumber = TextBoxStaffPhoneNumber.Text;
        staffTesting.StaffAddress = TextBoxStaffAddress.Text;
        staffTesting.StaffJobTitle = TextBoxStaffJobTitle.Text;

        Session["staffTesting"] = staffTesting;
        Response.Redirect("StaffViewer.aspx");
    }
}