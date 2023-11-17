using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess
{
    public class SqlDbAccessDapper : ISqlDbAccessDapper
    {
        string _connectionString;

        public SqlDbAccessDapper(string connectionString)
        {
            _connectionString = connectionString;    
        }

        public async Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
                var rows = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return rows.ToList();
            }
        }

        public async Task SaveDataAsync<T>(string storedProcedure, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
                
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
