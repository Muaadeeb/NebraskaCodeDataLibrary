using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data.Interfaces
{
	public interface ICategoryData
	{
		Task<int> CreateCategory(Category category);
		Task<int> UpdateCategory(Category category);
		Task<int> DeleteCategory(int categoryId);
		Task<List<Category>> GetCategoriesBySearchValue(string searchValue);
		Task<Category> GetCategoryByCategoryId(int categoryId);
		Task<List<Category>> GetAllCategories();
	}
}
