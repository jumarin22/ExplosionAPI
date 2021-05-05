using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string ReverseString(string input)
        {
            string output;

            if (input == null)
                output = "I didn't get a string!";
            else
            {
                // Borrowed from Kata best practices after I submitted a less efficient solution.
                output = new string(input.ToArray().Reverse().ToArray());
            }

            return output;
        }
    }
}