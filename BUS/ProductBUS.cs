using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class ProductBUS
    {
		public static DataTable GetBuyAndSellOfAllProductFromDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            return ProductDAO.GetBuyAndSellOfAllProductFromDateToDate(dateFrom, dateTo);
        }

		public static ProductDTO GetProductById(string id)
        {
            return ProductDAO.GetProductByID(id);
        }
		public static DataTable GetAllProductsWithCategoryAndUnitAndSellPrice()
        {
            return ProductDAO.GetAllProductsWithCategoryAndUnitAndSellPrice();
        }

		public static DataTable GetAllProductsWithCategoryAndUnit()
        {
            return ProductDAO.GetAllProductsWithCategoryAndUnit();
        }
        public static string InsertProduct(ProductDTO product)
        {
            if (string.IsNullOrEmpty(product.Id))
            {
          //      MessageBoxForm.Show("Mã sản phẩm không được để trống", "Lỗi");
                return "Mã sản phẩm không được để trống";
            }
            if (string.IsNullOrEmpty(product.Name))
            {
         //       MessageBoxForm.Show("Tên sản phẩm không được để trống", "Lỗi");
                return "Tên sản phẩm không được để trống";
            }

            if (ProductDAO.GetProductByID(product.Id) != null)
            {
             //   MessageBoxForm.Show("Id rau củ đã tồn tại", "Lỗi");
                return "Id rau củ đã tồn tại";
            }
            return ProductDAO.InsertProduct(product);
        }
        public static string UpdateProduct(ProductDTO product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
       //         MessageBoxForm.Show("Tên không được để trống", "Thông báo");
                return "Tên không được để trống";
            }
            return ProductDAO.UpdateProduct(product);
        }
        public static string DeleteProduct(ProductDTO product)
        {
            return ProductDAO.DeleteProduct(product);
        }
    }
}
