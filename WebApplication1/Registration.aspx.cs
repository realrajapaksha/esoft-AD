using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

    

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reg.aspx?uname=" + username.Text +
                "&email=" + email.Text +
                "&password=" + pwd.Text +
                "&conpwd=" + confirmpwd.Text);
        }
    }
}
