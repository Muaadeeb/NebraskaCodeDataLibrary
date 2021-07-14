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
using SubCategoryModel = NebraskaCodeDataLibraryDemo.Db.Models.SubCategoryModel;

namespace NebraskaCodeDataLibraryDemo.Data
{
	public class SubCategoryData : ISubCategoryData
	{
		private readonly IDataAccess _dataAccess;
		private readonly ConnectionStringData _connectionStringData;

		public SubCategoryData(IDataAccess dataAccess, ConnectionStringData connectionStringData)
		{
			_dataAccess = dataAccess;
			_connectionStringData = connectionStringData;
		}

		public async Task<int> CreateSubCategory(SubCategoryModel subCategory)
		{
			DynamicParameters p = new DynamicParameters();

			p.Add("SubCategoryName", subCategory.SubCategoryName);
			p.Add("CategoryId", subCategory.CategoryId);
			p.Add("CreatedUser", subCategory.CreatedUser);
			p.Add("UpdatedUser", subCategory.UpdatedUser);
			p.Add("CreatedDate", subCategory.CreatedDate);
			p.Add("UpdatedDate", subCategory.UpdatedDate);
			p.Add("SubCategoryId", DbType.Int32, direction: ParameterDirection.Output);

			await _dataAccess.SaveData("dbo.CreateSubCategory", p, _connectionStringData.SqlConnectionName);

			return p.Get<int>("SubCategoryId");
		}

		public async Task<int> UpdateSubCategory(SubCategoryModel subCategory)
		{
			return await _dataAccess.SaveData("dbo.UpdateSubCategory",
				new
				{
					SubCategoryId = subCategory.SubCategoryId,
					SubCategoryName = subCategory.SubCategoryName,
					CategoryId = subCategory.CategoryId,
					CreatedUser = subCategory.CreatedUser,
					UpdatedUser = subCategory.UpdatedUser,
					CreatedDate = subCategory.CreatedDate,
					UpdatedDate = subCategory.UpdatedDate
				},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<int> DeleteSubCategory(int subCategoryId)
		{
			return await _dataAccess.SaveData("dbo.DeleteSubCategory",
				new { SubCategoryId = subCategoryId},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<IEnumerable<SubCategoryModel>> GetSubCategoriesBySearchValue(string searchValue)
		{
			var result = await _dataAccess.LoadData<SubCategoryModel, dynamic>("dbo.GetSubCategoriesBySearchValue",
				new {SearchValue = searchValue},
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<SubCategoryModel>> GetSubCategoryBySubCategoryId(int subCategoryId)
		{
			var result = await _dataAccess.LoadData<SubCategoryModel, dynamic>("dbo.GetSubCategoryBySubCategoryId",
				new { SubCategoryId = subCategoryId },
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<SubCategoryModel>> GetAllSubCategories()
		{
			var result = await _dataAccess.LoadData<SubCategoryModel, dynamic>("dbo.GetAllSubCategories",
				new {  },
				_connectionStringData.SqlConnectionName);

			return result;
		}
	}
}