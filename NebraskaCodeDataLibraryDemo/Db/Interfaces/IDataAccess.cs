using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebraskaCodeDataLibraryDemo.Db.Interfaces
{
	public interface IDataAccess
	{
		Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
		Task<int> SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
	}
}
