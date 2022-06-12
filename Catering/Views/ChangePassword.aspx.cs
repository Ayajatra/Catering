using Catering.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catering.Views
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Models.User user = (Models.User)Session["user"];
            string oldPassword = TextBoxOldPassword.Text;
            string newPassword = TextBoxNewPassword.Text;
            string repeatPassword = TextBoxRepeatPassword.Text;

            string error = AuthController.ChangePassword(user, oldPassword, newPassword, repeatPassword);
            LabelError.Text = error;

            if (error != null)
                return;

            Session["user"] = null;
            HttpContext.Current.Response.Redirect("/");
        }
    }
}