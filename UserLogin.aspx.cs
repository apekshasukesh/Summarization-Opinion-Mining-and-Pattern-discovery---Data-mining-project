using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace drugs_symptoms_diseases
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)

                txtLoginId.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                DataTable tab = new DataTable();

                tab = obj.CheckUserLogin(txtLoginId.Text, txtPassword.Text);

                if (tab.Rows.Count > 0)
                {
                    if (dropdownlistType.SelectedIndex == 1 && tab.Rows[0]["UserType"].ToString().Equals("Admin"))
                    {
                        Session["AdminId"] = txtLoginId.Text;
                        Response.Redirect("~/Admin/ManageMP.aspx");
                    }
                    else if (dropdownlistType.SelectedIndex == 2 && tab.Rows[0]["UserType"].ToString().Equals("MedicalPractitioner"))
                    {
                        Session["MedicalPractitionerId"] = txtLoginId.Text;
                        Response.Redirect("~/MedicalPractitioner/OpinionModule.aspx");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('UserId/Password Incorrect!!!')</script>");
                }
            }
            catch
            {

            }
        }
    }
}