using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myPhonesFrontoffice2;

public partial class OrderForm : System.Web.UI.Page
{
    private object txtPrice;

    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder OrderTest = new clsOrder();
        OrderTest = (clsOrder)Session["OrderTest"];
        Response.Write(OrderTest.OrderId);
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsOrder OrderTest = new clsOrder();
        OrderTest.OrderId = txtOrderId.Text;
        OrderTest.OrderLineID = txtOrderLineID.Text;
        OrderTest.CustomerID = txtCustomerID.Text;
        OrderTest.StaffID = txtStaffID.Text;
        OrderTest.Price = txtPrice.Text;
        Session["OrderText"] = OrderTest;
        Response.Redirect("OrderFormViewer.aspx");
    }
}