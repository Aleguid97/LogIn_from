using System;
using System.Web;
using System.Web.UI;

namespace LogIn_from
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie Dioporco = new HttpCookie("LogIN");
            Dioporco.Values["User"] = UserName.Text;
            Dioporco.Values["Password"]= Password.Text;

            Dioporco.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(Dioporco);
            Response.Redirect("PaginaSuccessiva");

        }
    }
}
