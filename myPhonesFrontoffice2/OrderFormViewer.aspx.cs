using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderFormViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder OrderTest = new clsOrder();
        OrderTest = (clsOrder)Session["OrderText"];
        Response.Write(OrderTest.OrderId);
       
    }
}