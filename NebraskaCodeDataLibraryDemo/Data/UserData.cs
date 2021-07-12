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
	public class UserData : IUserData
	{
		private readonly IDataAccess _dataAccess;
		private readonly ConnectionStringData _connectionStringData;

		public UserData(IDataAccess dataAccess, ConnectionStringData connectionStringData)
		{
			_dataAccess = dataAccess;
			_connectionStringData = connectionStringData;
		}

		public async Task<int> CreateUser(User user)
		{
			DynamicParameters p = new DynamicParameters();

			p.Add("FirstName", user.FirstName);
			p.Add("LastName", user.LastName);
			p.Add("Email", user.Email);
			p.Add("Phone", user.Phone);
			p.Add("Address1", user.Address1);
			p.Add("Address2", user.Address2);
			p.Add("City", user.City);
			p.Add("State", user.State);
			p.Add("ZipCode", user.ZipCode);
			p.Add("IsActive", user.IsActive);
			p.Add("CreatedUser", user.CreatedUser);
			p.Add("UpdatedUser", user.UpdatedUser);
			p.Add("CreatedDate", user.CreatedDate);
			p.Add("UpdatedDate", user.UpdatedDate);

			p.Add("UserId", DbType.Int32, direction: ParameterDirection.Output);

			await _dataAccess.SaveData("dbo.CreateUser", p, _connectionStringData.SqlConnectionName);

			return p.Get<int>("UserId");
		}

		public async Task<int> UpdateUser(User user)
		{
			return await _dataAccess.SaveData("dbo.UpdateUser",
				new
				{
					UserId = user.UserId,
					FirstName = user.FirstName,
					LastName = user.LastName,
					Email = user.Email,
					Phone = user.Phone,
					Address1 = user.Address1,
					Address2 = user.Address2,
					City = user.City,
					State = user.State,
					ZipCode = user.ZipCode,
					IsActive = user.IsActive,
					CreatedUser =user.CreatedUser,
					UpdatedUser = user.UpdatedUser,
					CreatedDate = user.CreatedDate,
					UpdatedDate = user.UpdatedDate
				},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<int> DeleteUser(int userId)
		{
			return await _dataAccess.SaveData("dbo.DeleteUser",
				new { UserId = userId},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<List<User>> GetUsersBySearchValue(string searchValue)
		{
			var result = await _dataAccess.LoadData<User, dynamic>("dbo.GetUsersBySearchValue",
				new {SearchValue = searchValue},
				_connectionStringData.SqlConnectionName);

			return result.ToList();
		}

		public async Task<User> GetUserByUserId(int userId)
		{
			var result = await _dataAccess.LoadData<User, dynamic>("dbo.GetUserByUserId",
				new { UserId = userId },
				_connectionStringData.SqlConnectionName);

			return result.FirstOrDefault();
		}

		public async Task<List<User>> GetAllUsers()
		{
			var result = await _dataAccess.LoadData<User, dynamic>("dbo.GetAllUsers",
				new {  },
				_connectionStringData.SqlConnectionName);

			return result.ToList();
		}
	}
}
