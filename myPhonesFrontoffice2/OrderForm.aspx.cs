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
      // clsOrder OrderTest = new clsOrder();
      //  OrderTest = (clsOrder)Session["OrderTest"];
       // Response.Write(OrderTest.OrderId);
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsOrder OrderTest = new clsOrder();
        OrderTest.OrderId = TextBoxOrderID.Text;
        OrderTest.OrderLineID = TextBoxOrdlineID.Text;
        OrderTest.CustomerID = TextBoxCustomerID.Text;
        OrderTest.StaffID = TextBoxStaffID.Text;
        OrderTest.Price = TextBoxPrice.Text;
      //  OrderTest.Price = TextBoxPrice.Text;
        Session["OrderText"] = OrderTest;
        Response.Redirect("OrderFormViewer.aspx");
    }

    protected void Shipped_CheckedChanged(object sender, EventArgs e)
    {

    }
}

public class clsOrder
{
    public string OrderId { get; internal set; }
    public string OrderLineID { get; internal set; }
    public string CustomerID { get; internal set; }
    public string StaffID { get; internal set; }
    public string Price { get; internal set; }
}