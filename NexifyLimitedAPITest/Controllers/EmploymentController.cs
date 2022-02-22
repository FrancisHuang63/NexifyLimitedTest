using Microsoft.AspNetCore.Mvc;
using NexifyLimitedAPITest.Models;
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
        [HttpGet]
        public IEnumerable<EmploymentInformation> Get()
        {
            return new EmploymentInformation[] {};
        }
        
        [HttpPost]
        public void Post([FromBody] IEnumerable<EmploymentInformation> request)
        {
            
        }
        
        [HttpPut("{id}")]
        public void Put(IEnumerable<EmploymentInformation> request)
        {
        }
    }
}
