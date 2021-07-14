using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data.Interfaces
{
	public interface IUserData
	{
		Task<int> CreateUser(UserModel user);
		Task<int> UpdateUser(UserModel user);
		Task<int> DeleteUser(int userId);
		Task<IEnumerable<UserModel>> GetUsersBySearchValue(string searchValue);
		Task<IEnumerable<UserModel>> GetUserByUserId(int userId);
		Task<IEnumerable<UserModel>> GetAllUsers();
	}
}
