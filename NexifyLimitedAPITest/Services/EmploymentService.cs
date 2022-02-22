using Microsoft.Extensions.Configuration;
using NexifyLimitedAPITest.Models;
using NexifyLimitedAPITest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexifyLimitedAPITest.Services
{
    public class EmploymentService : IDataBaseService<EmploymentInformation>
    {
        private readonly IDataBaseAccessService<EmploymentInformation> _dataBaseAccessService;

        public EmploymentService(IDataBaseAccessService<EmploymentInformation> dataBaseAccessService)
        {
            _dataBaseAccessService = dataBaseAccessService;
        }

        public async Task<IEnumerable<EmploymentInformation>> GetAllAsync()
        {
            var sql = "SELECT * FROM [EmploymentInformation] ORDER BY [Id] ASC";
            return await _dataBaseAccessService.QueryAllAsync(sql);
        }

        public async Task<bool> UpsertDatasAsync(IEnumerable<EmploymentInformation> datas)
        {
            var sql = "INSERT OR REPLACE INTO [EmploymentInformation](Id, Name, Birthday, Salary, Address) " +
                      "VALUES (@ID, @Name, @Birthday, @Salary, @Address); ";
            return await _dataBaseAccessService.ExcuteQueryAsync(sql, datas) > 0;
        }
    }
}
