using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language;

namespace api.Controllers
{
    [Route("[controller]")]
    public class HelloController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return new Localise().Translate("en");
        }

        // GET api/values/5
        [HttpGet("{code}")]
        public string Get(string code)
        {
            return new Localise().Translate(code);
        }
    }
}
