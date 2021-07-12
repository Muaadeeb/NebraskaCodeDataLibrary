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
		Task<int> CreateUser(User user);
		Task<int> UpdateUser(User user);
		Task<int> DeleteUser(int userId);
		Task<List<User>> GetUsersBySearchValue(string searchValue);
		Task<User> GetUserByUserId(int userId);
		Task<List<User>> GetAllUsers();
	}
}
