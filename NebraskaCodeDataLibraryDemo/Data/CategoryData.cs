using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NebraskaCodeDataLibraryDemo.Data.Interfaces;
using NebraskaCodeDataLibraryDemo.Db;
using NebraskaCodeDataLibraryDemo.Db.Interfaces;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data
{
	public class CategoryData : ICategoryData
	{
		private readonly IDataAccess _dataAccess;
		private readonly ConnectionStringData _connectionStringData;

		public CategoryData(IDataAccess dataAccess, ConnectionStringData connectionStringData)
		{
			_dataAccess = dataAccess;
			_connectionStringData = connectionStringData;
		}

		public async Task<int> CreateCategory(CategoryModel category)
		{
			DynamicParameters p = new DynamicParameters();

			p.Add("CategoryName", category.CategoryName);
			p.Add("CreatedUser", category.CreatedUser);
			p.Add("UpdatedUser", category.UpdatedUser);
			p.Add("CreatedDate", category.CreatedDate);
			p.Add("UpdatedDate", category.UpdatedDate);
			p.Add("categoryId", DbType.Int32, direction: ParameterDirection.Output);

			await _dataAccess.SaveData("dbo.CreateCategory", p, _connectionStringData.SqlConnectionName);

			return p.Get<int>("categoryId");
		}

		public async Task<int> UpdateCategory(CategoryModel category)
		{
			return await _dataAccess.SaveData("dbo.UpdateCategory",
				new
				{
					CategoryId = category.CategoryId,
					CategoryName = category.CategoryName,
					CreatedUser =category.CreatedUser,
					UpdatedUser = category.UpdatedUser,
					CreatedDate = category.CreatedDate,
					UpdatedDate = category.UpdatedDate
				},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<int> DeleteCategory(int categoryId)
		{
			return await _dataAccess.SaveData("dbo.DeleteCategory",
				new { CategoryId = categoryId},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<IEnumerable<CategoryModel>> GetCategoriesBySearchValue(string searchValue)
		{
			var result = await _dataAccess.LoadData<CategoryModel, dynamic>("dbo.GetCategoriesBySearchValue",
				new {SearchValue = searchValue},
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<CategoryModel>> GetCategoryByCategoryId(int categoryId)
		{
			var result = await _dataAccess.LoadData<CategoryModel, dynamic>("dbo.GetCategoryByCategoryId",
				new { CategoryId = categoryId },
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<CategoryModel>> GetAllCategories()
		{
			var result = await _dataAccess.LoadData<CategoryModel, dynamic>("dbo.GetAllCategories",
				new {  },
				_connectionStringData.SqlConnectionName);

			return result;
		}
	}
}