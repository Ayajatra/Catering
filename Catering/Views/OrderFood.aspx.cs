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
    public partial class OrderFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Models.User user = (Models.User)Session["user"];

            OrderHeader[] headers = OrderController.GetAllHeadersOfUser(user.UserId);
            Repeater1.DataSource = headers;
            Repeater1.DataBind();
        }

        protected void NotifyPaymentButton_Click(object sender, CommandEventArgs e)
        {
            int orderHeaderId = Convert.ToInt32((string)e.CommandArgument);

            OrderController.NotifyPayment(orderHeaderId);

            LoadData();
        }
    }
}