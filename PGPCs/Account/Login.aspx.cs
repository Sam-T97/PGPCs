using System;
using System.Web;
using System.Web.UI;
using PGPCs.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public partial class Account_Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterHyperLink.NavigateUrl = "Register";
        var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        if (!String.IsNullOrEmpty(returnUrl))
        {
            RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
        }
    }

    protected void LogIn(object sender, EventArgs e)
    {
        var crypt = MD5.Create();
        string hashPW = BitConverter.ToString(crypt.ComputeHash(Encoding.ASCII.GetBytes(Password.Text)));
        var db = new PRODUCTCONTEXT();
        if (db.Customers.Where(u => u.EMAIL_ADDRESS == Email.Text).Any())
        {
            bool isFRZN = db.Customers.Where(u => u.EMAIL_ADDRESS == Email.Text).Select(FRZN => FRZN.FROZEN).FirstOrDefault();
            if (isFRZN == false)
            {
                Nullable<int> custID =
                db.Customers.Where(u => u.EMAIL_ADDRESS == Email.Text && u.PASSWORD == hashPW).Select(ID => ID.CUSTOMER_ID).FirstOrDefault();
                if (custID.HasValue && custID > 0)
                {
                    string UserID = custID.ToString();
                    Session.Add("UserID", UserID);
                    Response.Redirect("/");
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                    return;
                }
            }
            else
            {
                FailureText.Text = "Your account is frozen. If your account is new it must first be approved before you can access the site. <br/>" +
                    "If your account is not new then please contact us to discuss the issue.";
                ErrorMessage.Visible = true;
                return;
            }
        }
        if(db.Admins.Where(u => u.EMAIL_ADDRESS == Email.Text && u.PASSWORD == hashPW).Any())
        {
            Session.Add("isAdmin", true);
            Response.Redirect("/");
        }
        else
        {
            FailureText.Text = "Invalid username or password.";
            ErrorMessage.Visible = true;
        }

    }
}