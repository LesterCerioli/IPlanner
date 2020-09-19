using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPlanner.WebAPI.Controllers
{
    [Route("api/plans")]
    [ApiController]
    
    // https://localhost:5001/
    public class PlanController : ControllerBase
    {
        public string Plan()
        {
            return "Welcome to Plan Web API";
        }
    }
}
