using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexifyLimitedAPITest.Services.Interfaces
{
    public interface IDataBaseAccessService<T>
    {
        public Task<IEnumerable<T>> QueryAllAsync(string sql, object param = null);
        public Task<int> ExcuteQueryAsync(string sql, object param = null);
    }
}
