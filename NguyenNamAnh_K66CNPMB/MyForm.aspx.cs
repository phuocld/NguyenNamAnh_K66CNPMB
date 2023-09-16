using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NguyenNamAnh_K66CNPMB.ServiceReference1;

namespace NguyenNamAnh_K66CNPMB
{
    public partial class MyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient myService = new WebServiceSoapClient();

            Response.Write("<h3> Giờ hệ thống hiện tại là: " + myService.LayGioHeThong() + "</h3>");
            Response.Write("<h3> Số thứ nhất: 500. Số thứ hai là: 400. Vậy tổng là: " + myService.TinhTong(500,400) + "</h3>");

        }
    }
}