using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Toll.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("api/getdata")]
        public ActionResult Get()
        {
            var claims = HttpContext.User.Claims.Select(x => $"{x.Type}:{x.Value}");
            return Ok(new
            {
                Name = "Values API",
                Claims = claims.ToArray()
            });
        }
    }
}
