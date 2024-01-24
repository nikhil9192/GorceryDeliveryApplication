using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL.Interface
{
    public interface ICategory
    {
        int GetLastCategoryId();
        int SaveCategory(Category category);
        IEnumerable<Category> GetAllCategories();
        bool CategoryExists(string categoryName);
        bool CategoryExists(string categoryName,int id);
        Category GetCategoryById(int id);
        Category UpdateCategory(Category existingCategory);
        void DeleteCategory(Category categoryToDelete);
    }
}
