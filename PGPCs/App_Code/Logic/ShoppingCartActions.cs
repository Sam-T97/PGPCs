using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using PGPCs;
using PGPCs.Models;

namespace PGPCs.Logic
{
    public class ShoppingCartActions
    {

        public List<SHOPPINGCARTITEMS> GetCartItems(int cartID)
        {
            var db = new PRODUCTCONTEXT();
            return db.ShoppingCartItems.Where(i => i.CART_ID == cartID).ToList();
        }

        public void AddToCart(int custID, int prodID, int quantity)
        {
            
            int cartID = custID;
            var db = new PRODUCTCONTEXT();
            db.ShoppingCartItems.Add(new SHOPPINGCARTITEMS
            {
                CART_ID = cartID,
                PRODUCT_ID = prodID,
                QUANTITY = quantity
            });
            db.SaveChanges();
        }

        public void RemoveFromCart(int[] itemID)
        {
            var db = new PRODUCTCONTEXT();
            foreach(int id in itemID)
            {
                var item = db.ShoppingCartItems.Where(i => i.ITEM_ID == id).Single();
                db.ShoppingCartItems.Remove(item);
            }
            db.SaveChanges();
        }
    }
}