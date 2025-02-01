using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// We want the user to input an name and string that says "Hi {name}!".
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Returns a {greeting} to a name.
        /// </returns>
        /// <example>
        /// POST: api/q2/greeting?name=Amber -> Hi Amber!
        /// </example>
        [HttpGet(template:"greeting")]
        public string Get(string name)
        {
            return "Hi " + name + "!";
        }
    }
}
