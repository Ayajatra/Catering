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
    public partial class ManageOrders : System.Web.UI.Page
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
            OrderHeader[] headers = OrderController.GetAllHeaders();
            Repeater1.DataSource = headers;
            Repeater1.DataBind();
        }
    }
}