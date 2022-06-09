using Catering.Controllers;
using Catering.Models;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catering.Views
{
    public partial class ManageFoods : System.Web.UI.Page
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
            Food[] foods = FoodController.GetAll();
            Repeater1.DataSource = foods;
            Repeater1.DataBind();
        }

        protected void ToggleActiveButton_Click(object sender, CommandEventArgs e)
        {

        }

        protected void DeleteButton_Click(object sender, CommandEventArgs e)
        {
            int foodId = Convert.ToInt32((string)e.CommandArgument);

            string error = FoodController.DeleteById(foodId);
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