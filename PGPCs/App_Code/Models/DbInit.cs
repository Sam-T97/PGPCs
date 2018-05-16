using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;


namespace PGPCs.Models
{
    public class DbInit : DropCreateDatabaseIfModelChanges<PRODUCTCONTEXT>
    {
        protected override void Seed(PRODUCTCONTEXT context)
        {
            GetCats().ForEach(Cat => context.Categories.Add(Cat));
            GetProds().ForEach(Prod => context.Products.Add(Prod));
            GetCusts().ForEach(Cust => context.Customers.Add(Cust));
            GetAdmins().ForEach(Ad => context.Admins.Add(Ad));
        }

        private static List<CATEGORY> GetCats()
        {
            var Cats = new List<CATEGORY>
            {
                new CATEGORY
                {
                    CATEGORY_ID = 1,
                    CATEGORY_NAME = "Processors"
                },
                new CATEGORY
                {
                    CATEGORY_ID = 2,
                    CATEGORY_NAME = "Memory"
                },
                new CATEGORY
                {
                    CATEGORY_ID = 3,
                    CATEGORY_NAME = "Motherboards"
                },
                new CATEGORY
                {
                    CATEGORY_ID = 4,
                    CATEGORY_NAME = "Storage"
                },
                new CATEGORY
                {
                    CATEGORY_ID =5,
                    CATEGORY_NAME = "Graphics Cards"
                },
                new CATEGORY
                {
                    CATEGORY_ID = 6,
                    CATEGORY_NAME = "Power Supplies"
                }
            };
            return Cats;
        }

        private static List<PRODUCT> GetProds()
        {
            var Prods = new List<PRODUCT>
            {
                new PRODUCT
                {
                    PRODUCT_ID = 1,
                    PRODUCT_NAME = "AMD Ryzen R5 1600",
                    PRODUCT_DESCRIPTION = "MOOOAAARRRR Cores!",
                    IMAGE_NAME = "R51600.jpg",
                    PRICE = 180,
                    CATEGORY_ID = 1
                },
                new PRODUCT
                {
                    PRODUCT_ID = 2,
                    PRODUCT_NAME ="AMD Ryzen R5 1500",
                    PRODUCT_DESCRIPTION = "Moar cores but slightly less than the 1600",
                    IMAGE_NAME ="R51600.jpg",
                    PRICE = 150,
                    CATEGORY_ID = 1
                },
                new PRODUCT
                {
                    PRODUCT_ID = 3,
                    PRODUCT_NAME = "AMD Ryzen 5 1400",
                    PRODUCT_DESCRIPTION = "Test",
                    IMAGE_NAME ="R51600.jpg",
                    PRICE = 120,
                    CATEGORY_ID = 1
                },
                new PRODUCT
                {
                    PRODUCT_ID = 4,
                    PRODUCT_NAME = "AMD Ryzen R5 1600x",
                    PRODUCT_DESCRIPTION = "Test",
                    IMAGE_NAME ="R51600.jpg",
                    PRICE = 210,
                    CATEGORY_ID = 1
                }

            };
            return Prods;
        }
        private static List<CUSTOMER> GetCusts()
        {
            var crypt = MD5.Create();
            var Custs = new List<CUSTOMER> {
            new CUSTOMER
            {
                CUSTOMER_ID = 1,
                CUSTOMER_FIRST_NAME = "test",
                CUSTOMER_LAST_NAME = "test",
                HOUSE_NUMBER = 1,
                ADDRESS_LINE_1 = "aijlkohdoihu",
                ADDRESS_LINE_2 = "iuoasbd",
                CITY = "usbf",
                COUNTY = "iodng",
                POSTCODE = "hfg pwo",
                EMAIL_ADDRESS = "Test@test.com",
                PASSWORD = BitConverter.ToString(crypt.ComputeHash(Encoding.ASCII.GetBytes("Test"))),
                FROZEN = false,
                NEW_ACCT = false               
            }
            };
            return Custs;
        }
        private static List<ADMIN> GetAdmins()
        {
            var crypt = MD5.Create();
            var Admins = new List<ADMIN>
            {
                new ADMIN
                {
                    ADMIN_ID = 1,
                    EMAIL_ADDRESS = "AdminTest@Admin.com",
                    PASSWORD = BitConverter.ToString(crypt.ComputeHash(Encoding.ASCII.GetBytes("Admin")))
                }
            };
            return Admins;
        }
    }
}

