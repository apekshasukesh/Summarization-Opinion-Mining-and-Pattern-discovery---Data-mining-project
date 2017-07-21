using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drugs_symptoms_diseases
{
    public partial class Signout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            //Response.Write("<script>window.top.navigate('UserLogin.aspx')</script>");
            Response.Redirect("UserLogin.aspx");
        }
    }
}