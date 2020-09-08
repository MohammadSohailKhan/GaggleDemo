using MdSohail_GaggleChallenge.Models.Nhl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MdSohail_GaggleChallenge.Models;

namespace MdSohail_GaggleChallenge.Data
{
    public class DummyData
    {

        public static List<Product> getProducts(NhlContext context)
        {
            List<Product> Products = new List<Product>()
            {
                new Product {

                GUID= "fdfdgfg",
                ProductName = " sohail",
                Description ="contextname",
                CreatedDate = "15-6-2013",
                UpdatedDate = "2014/05/1",
                Active= false

            },
                  new Product {

                GUID= "yhyhfh",
                ProductName = " mohmmad",
                Description ="contextname",
                CreatedDate = "15/6/2013",
                UpdatedDate= "15-02-2017",
                Active= true

            },                  

};
            return Products;
        }

        internal static object getProducts()
        {
            throw new NotImplementedException();
        }

        internal static object getProducts(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
