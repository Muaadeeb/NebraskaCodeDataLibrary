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
		Task<int> CreateSubCategory(SubCategoryModel subCategory);
		Task<int> UpdateSubCategory(SubCategoryModel subCategory);
		Task<int> DeleteSubCategory(int subCategoryId);
		Task<IEnumerable<SubCategoryModel>> GetSubCategoriesBySearchValue(string searchValue);
		Task<IEnumerable<SubCategoryModel>> GetSubCategoryBySubCategoryId(int subCategoryId);
		Task<IEnumerable<SubCategoryModel>> GetAllSubCategories();
	}
}
