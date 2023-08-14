using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO dao = new CategoryDAO();
        FStoreContext context = new FStoreContext();

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategoryByID(int categoryID)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryId == categoryID);
        }
    }
}
