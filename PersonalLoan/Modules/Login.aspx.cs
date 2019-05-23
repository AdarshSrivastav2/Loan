using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelClasses;
using BAL;

namespace PersonalLoan.Modules
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ModelClasses.Login l1 = new ModelClasses.Login();
            l1.Id = TextBox1.Text;
            l1.Password = TextBox2.Text;

            LoginBl lbl = new LoginBl();
          
        }
    }
}