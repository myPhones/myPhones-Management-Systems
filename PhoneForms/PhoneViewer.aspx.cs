using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhoneViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsPhones AnPhones = new clsPhones();
        AnPhones = (clsPhones)Session["AnPhones"];
        Response.Write(AnPhones.PhoneId);
    }
} 