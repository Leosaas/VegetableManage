using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class ProductPriceBUS
    {
		public static string AddProductBuyPrice(ProductPriceDTO productPrice)
		{
			return ProductPriceDAO.AddProductBuyPrice(productPrice);
		}
		public static string AddProductSellPrice(ProductPriceDTO productPrice)
        {
            return ProductPriceDAO.AddProductSellPrice(productPrice);
        }
        public static DataTable GetAllProductSellPrice()
        {
            return ProductPriceDAO.GetAllProductSellPrice();
        }
        public static DataTable GetSellPriceOfProduct(string id)
        {
            return ProductPriceDAO.GetSellPriceOfProduct(id);
        }
		public static DataTable GetBuyPriceOfProduct(string id)
		{
			return ProductPriceDAO.GetBuyPriceOfProduct(id);
		}
		public static DataTable GetProductSellPriceByDate(string productId,DateTime dateFrom, DateTime dateTo)
        {
            return ProductPriceDAO.GetProductSellPriceByDate(productId,dateFrom, dateTo);
        }
		public static DataTable GetProductBuyPriceByDate(string productId, DateTime dateFrom, DateTime dateTo)
		{
			return ProductPriceDAO.GetProductBuyPriceByDate(productId, dateFrom, dateTo);
		}
	}
}
