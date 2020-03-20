using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhoneForms : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsPhones AnPhones = new clsPhones();
        AnPhones = (clsPhones)Session["AnPhones"];
        Response.Write(AnPhones.PhoneId);

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsPhones AnPhones = new clsPhones();
        AnPhones.PhoneId = txtPhoneId.Text;
        AnPhones.PhoneId = txtPhoneDescription.Text;
        AnPhones.PhoneId = txtPhoneMake.Text;
        AnPhones.PhoneId = txtPhoneModel.Text;
        AnPhones.PhoneId = txtPhoneWeight.Text;
        AnPhones.PhoneId = txtPhoneColour.Text;
        AnPhones.PhoneId = txtDatePhoneAdded.Text;
        AnPhones.PhoneId = txtPrice.Text;
        AnPhones.PhoneId = txtInStock.Text;
       
        Session["AnPhones"] = AnPhones;
        Response.Redirect("PhoneViewer.aspx");
    }
}