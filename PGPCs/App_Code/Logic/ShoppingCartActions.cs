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
            var cartItem = db.ShoppingCartItems.SingleOrDefault(c => c.CART_ID == cartID && c.PRODUCT_ID == prodID);
            if (cartItem == null)
            {
                db.ShoppingCartItems.Add(new SHOPPINGCARTITEMS
                {
                    CART_ID = cartID,
                    PRODUCT_ID = prodID,
                    QUANTITY = quantity
                });
            }
            else
            {
                cartItem.QUANTITY = cartItem.QUANTITY + quantity;
            }
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

        public void ClearCart(int ID)
        {
            var db = new PRODUCTCONTEXT();
            var cartItems = db.ShoppingCartItems.Where(i => i.CART_ID == ID);
            foreach(var item in cartItems)
            {
                db.ShoppingCartItems.Remove(item);
            }
            db.SaveChanges();
        }
    }
}