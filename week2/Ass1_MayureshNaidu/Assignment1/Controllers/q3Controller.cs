using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// We want the user to input an integer and get its cube as a response.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>
        /// Returns the cube of an integer.
        /// </returns>
        /// <example>
        /// POST: api/q3/cube/3 -> 27
        /// </example>
        [HttpGet("cube/{num}")]
        public int Get(int num)
        {
            return num * num * num ;
        }
    }
}
