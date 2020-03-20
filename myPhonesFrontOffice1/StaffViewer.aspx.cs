using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myPhonesTesting;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staffTest = new clsStaff();
        staffTest = (clsStaff)Session["staffTest"];
        Response.Write(staffTest.staffId);
    }
}