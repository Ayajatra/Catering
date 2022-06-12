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
    public partial class ManageOrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PaymentStatus[] paymentStatuses = PaymentStatusController.GetAll();
                DropDownPaymentStatus.DataValueField = "PaymentStatusId";
                DropDownPaymentStatus.DataTextField = "PaymentStatusName";
                DropDownPaymentStatus.DataSource = paymentStatuses;
                DropDownPaymentStatus.DataBind();

                OrderStatus[] orderStatuses = OrderStatusController.GetAll();
                DropDownListOrderStatus.DataValueField = "OrderStatusId";
                DropDownListOrderStatus.DataTextField = "OrderStatusName";
                DropDownListOrderStatus.DataSource = orderStatuses;
                DropDownListOrderStatus.DataBind();

                int orderHeaderId = Convert.ToInt32(Request.QueryString["id"]);
                OrderHeader header = OrderController.FindHeaderById(orderHeaderId);
                TextBoxOrderHeaderId.Text = header.OrderHeaderId.ToString();
                TextBoxUsername.Text = header.User.Username;
                TextBoxOrderDate.Text = header.OrderDate.ToString();
                DropDownPaymentStatus.SelectedValue = header.PaymentStatusId.ToString();
                DropDownListOrderStatus.SelectedValue = header.OrderStatusId.ToString();

                LoadData();
            }
        }

        private void LoadData()
        {
            int orderHeaderId = Convert.ToInt32(Request.QueryString["id"]);
            OrderDetail[] details = OrderController.GetDetails(orderHeaderId);
            Repeater1.DataSource = details;
            Repeater1.DataBind();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int orderHeaderId = Convert.ToInt32(Request.QueryString["id"]);
            int paymentStatusId = Convert.ToInt32(DropDownPaymentStatus.SelectedValue);
            int orderStatusId = Convert.ToInt32(DropDownListOrderStatus.SelectedValue);

            OrderController.UpdateStatus(orderHeaderId, paymentStatusId, orderStatusId);

            HttpContext.Current.Response.Redirect("/Views/ManageOrders");
        }
    }
}