using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NebraskaCodeDataLibraryDemo.Db.Interfaces;

namespace NebraskaCodeDataLibraryDemo.Db
{
	public class DataAccess : IDataAccess
	{
		private readonly IConfiguration _configuration;

		public DataAccess(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
		{
			string connectionString = _configuration.GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				var rows = await connection.QueryAsync<T>(storedProcedure, parameters,
					commandType: CommandType.StoredProcedure);

				return rows.ToList();
			}
		}

		public async Task<int> SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
		{
			string connectionString = _configuration.GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				return await connection.ExecuteAsync(storedProcedure, parameters,
					commandType: CommandType.StoredProcedure);

			}
		}
	}
}