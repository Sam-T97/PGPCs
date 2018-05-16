using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;
using System.Security.Cryptography;
using System.Text;

public partial class AdminPages_AddAnAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void CreateUser_Click(object sender, EventArgs e)
    {
        var crypt = MD5.Create();
        var db = new PRODUCTCONTEXT();
        ADMIN toAdd = new ADMIN();
        toAdd.EMAIL_ADDRESS = EmailAddress.Text;
        string hashPW = BitConverter.ToString(crypt.ComputeHash(Encoding.ASCII.GetBytes(Password.Text)));
        toAdd.PASSWORD = hashPW;
        db.Admins.Add(toAdd);
        db.SaveChanges();
        Response.Redirect(Request.RawUrl);
    }
}