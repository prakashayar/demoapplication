using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace DemoCRUD
{
    /// <summary>
    /// Used for login related functionality
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "prakash";
            txtPassword.Text = "prakash@123";
        }


        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if(txtUserName.Text == "prakash" && txtPassword.Text== "prakash@123")
                {
                    // Implementation of form authentication
                    FormsAuthentication.SetAuthCookie(txtUserName.Text.Trim(), false);
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(txtUserName.Text, false,10);
                    HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                    Response.Cookies.Add(httpCookie);

                    String returnUrl1;
                    // the login is successful
                    if (Request.QueryString["ReturnUrl"] == null)
                    {
                        returnUrl1 = "Notes.aspx";
                    }
                    //login not unsuccessful 
                    else
                    {
                        returnUrl1 = Request.QueryString["ReturnUrl"];
                    }
                    Response.Redirect(returnUrl1);

                }
                else
                {
                    lblMessage.Text = "Username or Password not match. Try again.";
                }
            }
            
        }
    }
}