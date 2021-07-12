using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data.Interfaces
{
	public interface ISubCategoryData
	{
		Task<int> CreateSubCategory(SubCategory subCategory);
		Task<int> UpdateSubCategory(SubCategory subCategory);
		Task<int> DeleteSubCategory(int subCategoryId);
		Task<List<SubCategory>> GetSubCategoriesBySearchValue(string searchValue);
		Task<SubCategory> GetSubCategoryBySubCategoryId(int subCategoryId);
		Task<List<SubCategory>> GetAllSubCategories();
	}
}
