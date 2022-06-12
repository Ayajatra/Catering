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
    public partial class NewOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Food[] foods = FoodController.GetAll();
                DropDownFood.DataTextField = "FoodName";
                DropDownFood.DataValueField = "FoodId";
                DropDownFood.DataSource = foods;
                DropDownFood.DataBind();

                var cartItems = new List<OrderDetail>();
                Session["cartItems"] = cartItems;
                LoadData(cartItems);
            }
        }

        private void LoadData(List<OrderDetail> cartItems)
        {
            Repeater1.DataSource = cartItems;
            Repeater1.DataBind();
        }

        protected void DeleteButton_Click(object sender, CommandEventArgs e)
        {
            var cartItems = (List<OrderDetail>)Session["cartItems"];
            int foodId = Convert.ToInt32((string)e.CommandArgument);

            cartItems.RemoveAll(x => x.FoodId == foodId);

            Session["cartItems"] = cartItems;
            LoadData(cartItems);
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            var cartItems = (List<OrderDetail>)Session["cartItems"];
            int foodId = Convert.ToInt32(DropDownFood.SelectedValue);
            string foodName = DropDownFood.SelectedItem.Text;

            OrderDetail item = cartItems.FirstOrDefault(x => x.FoodId == foodId);
            if (item != null)
            {
                item.FoodQuantity++;
            }
            else
            {
                cartItems.Add(new OrderDetail
                {
                    FoodId = foodId,
                    Food = new Food
                    {
                        FoodId = foodId,
                        FoodName = foodName
                    },
                    FoodQuantity = 1
                });
            }

            Session["cartItems"] = cartItems;
            LoadData(cartItems);
        }

        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            var cartItems = (List<OrderDetail>)Session["cartItems"];
            var user = (Models.User)Session["user"];

            string error = OrderController.FinalizeOrder(user.UserId, cartItems);
            LabelError.Text = error;

            if (error != null)
                return;

            HttpContext.Current.Response.Redirect("/Views/OrderFood");
        }

        protected void ReduceQuantity_Click(object sender, CommandEventArgs e)
        {
            var cartItems = (List<OrderDetail>)Session["cartItems"];
            int foodId = Convert.ToInt32((string)e.CommandArgument);

            OrderDetail item = cartItems.FirstOrDefault(x => x.FoodId == foodId);
            item.FoodQuantity--;
            if (item.FoodQuantity <= 0)
                cartItems.Remove(item);

            Session["cartItems"] = cartItems;
            LoadData(cartItems);
        }

        protected void AddQuantity_Click(object sender, CommandEventArgs e)
        {
            var cartItems = (List<OrderDetail>)Session["cartItems"];
            int foodId = Convert.ToInt32((string)e.CommandArgument);

            OrderDetail item = cartItems.FirstOrDefault(x => x.FoodId == foodId);
            item.FoodQuantity++;

            Session["cartItems"] = cartItems;
            LoadData(cartItems);
        }
    }
}