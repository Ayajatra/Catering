using Catering.Controllers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catering.Views
{
    public partial class AddFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FoodCategory[] foodCategories = FoodCategoryController.GetAll();
                DropDownFoodCategory.DataSource = foodCategories;
                DropDownFoodCategory.DataValueField = "FoodCategoryId";
                DropDownFoodCategory.DataTextField = "FoodCategoryName";
                DropDownFoodCategory.DataBind();
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string foodName = TextBoxFoodName.Text;
            string foodPrice = TextBoxFoodPrice.Text;
            bool foodActiveStatus = CheckBoxFoodActiveStatus.Checked;
            int foodCategoryId = Convert.ToInt32(DropDownFoodCategory.SelectedValue);

            string error = FoodController.Add(foodName, foodPrice, foodActiveStatus, foodCategoryId);
            LabelError.Text = error;
            if (error != null)
                return;

            HttpContext.Current.Response.Redirect("/Views/ManageFoods");
        }
    }
}