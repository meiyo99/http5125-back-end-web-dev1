using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// We want to return the response "Who's there?"
        /// </summary>
        /// <returns>
        /// Returns the start of a knock knock joke.
        /// </returns>
        /// <example>
        /// POST: api/q4/knockknock -> Who's there?
        /// </example
        [HttpPost(template:"knockknock")]
        public string Post()
        {
            return "Who's there?";
        }
    }
}
