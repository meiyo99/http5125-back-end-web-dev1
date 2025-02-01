using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// We want the user to input an integer and receive it in the output string.
        /// </summary>
        /// <param name="secret"></param>
        /// <returns>
        /// Returns the acknowledgement of the {secret} int.
        /// </returns>
        /// <example>
        /// POST: api/q5/secret -> Shh.. the secret is 345
        /// </example>
        [HttpPost(template:"secret")]
        public string Post([FromBody]int secret)
        {
            return "Shh.. the secret is " + secret;
        }
    }
}
