using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs.Models;
using PGPCs.Logic;
using System.Data.Entity;

/// <summary>
/// Summary description for AccountActions
/// </summary>
public class AccountActions
{
    
    public AccountActions()
    {
        
    }
    
    public void freezeAccount(int ID)
    {
        var db = new PRODUCTCONTEXT();
        CUSTOMER toEdit = db.Customers.Where(i => i.CUSTOMER_ID == ID).First();
        toEdit.FROZEN = true;
        db.SaveChanges();
        
    }

    public void unFreezeAccount(int ID)
    {
        var db = new PRODUCTCONTEXT();
        CUSTOMER toEdit = db.Customers.Where(i => i.CUSTOMER_ID == ID).First();
        toEdit.FROZEN = false;
        db.SaveChanges();
    }
}