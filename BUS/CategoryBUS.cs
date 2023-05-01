using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CategoryBUS
    {
		public static CategoryDTO GetCategoryByID(string id)
        {
            return CategoryDAO.GetCategoryByID(id); 
        }

		public static DataTable GetAllCategory()
        {
            return CategoryDAO.GetAllCategory();
        }
        public static string InsertCategory(CategoryDTO category)
        {
            if (string.IsNullOrEmpty(category.Id))
            {
              //  MessageBoxForm.Show("Mã loại không được để trống", "Thông báo");
                return "Mã loại không được để trống !";
            }
            if (string.IsNullOrEmpty(category.Name))
            {
             //   MessageBoxForm.Show("Tên không được để trống", "Thông báo");
                return "Tên không được để trống !";
            }
            if (CategoryDAO.GetCategoryByID(category.Id) != null)
            {
            //    MessageBoxForm.Show("Mã loại rau củ đã có", "Thông báo");
                return "Mã loại rau củ đã có !";
            }
            return CategoryDAO.InsertCategory(category);
        }
        public static string UpdateCategory(CategoryDTO category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
              //  MessageBoxForm.Show("Tên không được để trống", "Thông báo");
                return "Tên không được để trống !";
            }
            return CategoryDAO.UpdateCategory(category);
        }
        public static string DeleteCategory(CategoryDTO category)
        { 
            return CategoryDAO.DeleteCategory(category);
        }

    }
}
