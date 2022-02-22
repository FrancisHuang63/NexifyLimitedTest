using Dapper;
using Microsoft.Extensions.Configuration;
using NexifyLimitedAPITest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NexifyLimitedAPITest.Services
{
    public class DataBaseAccessService<T> : IDataBaseAccessService<T>
    {
        private readonly IConfiguration _config;
        private string _connectionString => string.Format(_config.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection"), Directory.GetCurrentDirectory());
        public DataBaseAccessService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> QueryAllAsync(string sql, object param = null)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                return await conn.QueryAsync<T>(sql, param);
            }
        }

        public async Task<int> ExcuteQueryAsync(string sql, object param = null)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                return await conn.ExecuteAsync(sql, param);
            }
        }
    }
}
