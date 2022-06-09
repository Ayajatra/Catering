using Catering.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catering.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;

            string error = AuthController.Register(username, password, confirmPassword);
            LabelError.Text = error;

            if (error != null)
                return;

            Page.ClientScript.RegisterStartupScript(
                GetType(),
                "alertThenRedirect",
                "alert('Sucessfuly registered!');window.location.href='/';",
                true);
        }
    }
}