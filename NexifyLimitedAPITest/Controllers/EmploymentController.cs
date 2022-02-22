using Microsoft.AspNetCore.Mvc;
using NexifyLimitedAPITest.Models;
using NexifyLimitedAPITest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexifyLimitedAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentController : ControllerBase
    {

        private readonly IDataBaseService<EmploymentInformation> _dateBaseService;
        public EmploymentController(IDataBaseService<EmploymentInformation> dateBaseService)
        {
            _dateBaseService = dateBaseService;
        }

        [HttpGet]
        public async Task<IEnumerable<EmploymentInformation>> Get()
        {
            return await _dateBaseService.GetAllAsync();
        }
        
        [HttpPost]
        public async Task<bool> Post([FromBody] IEnumerable<EmploymentInformation> request)
        {
            return await _dateBaseService.UpsertDatasAsync(request);
        }
    }
}
