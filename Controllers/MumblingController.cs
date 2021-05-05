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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string MumbleString(string input)
        {
            string output;

            if (input == null)
                output = "I didn't get a string!";
            else
            {
                // Borrowed from Kata best practices after I submitted a less efficient solution.
                // https://www.codewars.com/kata/mumbling
                output = string.Join("-", input.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            }

            return output;
        }
    }
}