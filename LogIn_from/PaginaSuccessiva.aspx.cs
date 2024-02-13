using System;
using System.Reflection.Emit;
using System.Web;

namespace LogIn_from
{
    public partial class PaginaSuccessiva : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            Label1.text = request.cookies
           
        }

        public void Logout (object sender, EventArgs e)
        {
            HttpCookie Dioporco = new HttpCookie("LogIn");
            Dioporco.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(Dioporco);
            Response.Redirect("Default");

        }
    }
}
