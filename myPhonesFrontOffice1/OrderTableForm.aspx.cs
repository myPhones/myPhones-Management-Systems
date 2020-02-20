using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderTableForm : System.Web.UI.Page
{
    public clsOrder TestData { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder OrderTest = new clsOrder();
        TestData = (clsOrder)Session["TestData"];
        Reponse.Write(OrderTest)


    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}