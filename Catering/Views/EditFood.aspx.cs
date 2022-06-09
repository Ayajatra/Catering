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
    public partial class EditFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string foodId = Request.QueryString["id"];
                if (!int.TryParse(foodId, out int foodIdInt))
                {
                    Response.Redirect("/Views/ManageFoods");
                    return;
                }

                Food food = FoodController.FindById(foodIdInt);
                if (food == null)
                {
                    Response.Redirect("/Views/ManageFoods");
                    return;
                }

                FoodCategory[] foodCategories = FoodCategoryController.GetAll();
                DropDownFoodCategory.DataSource = foodCategories;
                DropDownFoodCategory.DataValueField = "FoodCategoryId";
                DropDownFoodCategory.DataTextField = "FoodCategoryName";
                DropDownFoodCategory.DataBind();

                TextBoxFoodName.Text = food.FoodName.ToString();
                TextBoxFoodPrice.Text = food.FoodPrice.ToString();
                CheckBoxFoodActiveStatus.Checked = food.FoodActiveStatus;
                DropDownFoodCategory.SelectedValue = food.FoodCategoryId.ToString();
            }
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            string foodId = Request.QueryString["id"];
            string foodName = TextBoxFoodName.Text;
            string foodPrice = TextBoxFoodPrice.Text;
            bool foodActiveStatus = CheckBoxFoodActiveStatus.Checked;
            int foodCategoryId = Convert.ToInt32(DropDownFoodCategory.SelectedValue);

            string error = FoodController.Update(foodId, foodName, foodPrice, foodActiveStatus, foodCategoryId);
            LabelError.Text = error;
            if (error != null)
                return;

            HttpContext.Current.Response.Redirect("/Views/ManageFoods");
        }
    }
}