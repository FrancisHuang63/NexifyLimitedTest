using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexifyLimitedAPITest.Services.Interfaces
{
    public interface IDataBaseService<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<bool> UpsertDatasAsync(IEnumerable<T> datas);
    }
}
