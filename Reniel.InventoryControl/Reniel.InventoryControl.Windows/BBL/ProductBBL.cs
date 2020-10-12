using System;
using System.Collections.Generic;
using System.Linq;

namespace Reniel.InventoryControl.Windows.BLL
{
    public static class ProductBLL
    {
        public static DAL.ProductsDBContex db = new DAL.ProductsDBContex();
        public static List<Models.Product> GetList(String sortBy = "ProductName", string sortOrder = "asc")


        {
            if (sortBy.ToLower() == "ProductName" && sortOrder.ToLower() == "asc")
            {
                return db.Products.OrderBy(e => e.ProductName).ToList();
            }
            else if (sortBy.ToLower() == "ProductName" && sortOrder.ToLower() == "asc")
            {
                return db.Products.OrderByDescending(e => e.ProductName).ToList();
            }
             else if (sortBy.ToLower() == "Price" && sortOrder.ToLower() == "asc")
            {
                return db.Products.OrderBy(e => e.ProductName).ToList();
            }
            else
            {
                return db.Products.OrderByDescending(e => e.ProductName).ToList();
            }

        }
    }
}
