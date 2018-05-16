using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using System.Text;
using PGPCs;
using PGPCs.Models;
using System.Security.Cryptography;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        var crypt = MD5.Create();
        var db = new PRODUCTCONTEXT();
        var Cust = new CUSTOMER();
        string hashPW = BitConverter.ToString(crypt.ComputeHash(Encoding.ASCII.GetBytes(Password.Text)));
        Cust.CUSTOMER_FIRST_NAME = FirstName.Text;
        Cust.CUSTOMER_LAST_NAME = LastName.Text;
        Cust.HOUSE_NUMBER = int.Parse(HouseNumber.Text);
        Cust.ADDRESS_LINE_1 = AddressLine1.Text;
        Cust.ADDRESS_LINE_2 = AddressLine2.Text;
        Cust.CITY = City.Text;
        Cust.COUNTY = County.Text;
        Cust.POSTCODE = PostCode.Text;
        Cust.EMAIL_ADDRESS = EmailAddress.Text;
        Cust.PASSWORD = hashPW;
        Cust.FROZEN = true;
        db.Customers.Add(Cust);
        db.SaveChanges();
        Response.Redirect("/Account/Login.aspx");
    }
}