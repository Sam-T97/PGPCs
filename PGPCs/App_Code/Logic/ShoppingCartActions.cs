using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using PGPCs;
using PGPCs.Models;

namespace PGPCs
{
    public class ShoppingCartActions
    {
        public int GetCart(int custID)
        {
            
            var db = new PRODUCTCONTEXT();
            int cartID = db.ShoppingCart.Where(u => u.CUSTOMER_ID == custID).Select(i => i.SHOPPING_CART_ID).FirstOrDefault();
            return cartID;
        }

        public IQueryable<SHOPPINGCARTITEMS> GetCartItems(int cartID)
        {
            var db = new PRODUCTCONTEXT();
            IQueryable<SHOPPINGCARTITEMS> query = db.ShoppingCartItems;
            query = query.Where(i => i.CART_ID == cartID);
            return query;
        }

        public void AddToCart(int custID, int prodID, int quantity)
        {
            int cartID = GetCart(custID);
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