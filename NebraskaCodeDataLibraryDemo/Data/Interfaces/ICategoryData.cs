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
		Task<int> CreateCategory(CategoryModel category);
		Task<int> UpdateCategory(CategoryModel category);
		Task<int> DeleteCategory(int categoryId);
		Task<IEnumerable<CategoryModel>> GetCategoriesBySearchValue(string searchValue);
		Task<IEnumerable<CategoryModel>> GetCategoryByCategoryId(int categoryId);
		Task<IEnumerable<CategoryModel>> GetAllCategories();
	}
}
