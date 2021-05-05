using API_RESTful.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]/v{version:ApiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonbusiness _personBusiness;


        public PersonController(ILogger<PersonController> logger, IPersonbusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }


    }
}
