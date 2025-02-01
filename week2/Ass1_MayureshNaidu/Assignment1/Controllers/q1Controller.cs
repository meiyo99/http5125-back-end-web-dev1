using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// We want to return the message "Welcome to 5125!".
        /// </summary>
        /// <returns>
        /// Returns a welcome message.
        /// </returns>
        /// <example>
        /// POST: api/q1/welcome -> Welcome to 5125!?
        /// </example
        [HttpGet(template: "welcome")]
        public string Get()
        {
            return "Welcome to 5125!";
        }

    }
}
