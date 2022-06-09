using Catering.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catering.Views
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Models.User[] users = UserController.GetAll();
            Repeater1.DataSource = users;
            Repeater1.DataBind();
        }

        protected void DeleteButton_Click(object sender, CommandEventArgs e)
        {
            int userId = Convert.ToInt32((string)e.CommandArgument);

            string error = UserController.DeleteById(userId);
            if (error != null)
            {
                Page.ClientScript.RegisterStartupScript(
                    GetType(),
                    "alert",
                    $"alert('{error}');",
                    true);
                return;
            }

            LoadData();
        }
    }
}