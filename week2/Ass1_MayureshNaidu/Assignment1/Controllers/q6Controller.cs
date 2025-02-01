using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// We want to receive the area of a hexagon, user inputs thelength of a side.
        /// </summary>
        /// <param name="side"></param>
        /// <returns>
        /// Returns the area of a reguular hexagon with side {S}.
        /// </returns>
        /// <example>
        /// GET: api/q6/hexagon?side=2 -> 10.392304845413264
        /// </example>
        [HttpGet(template:"hexagon")]
        public double Get(double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }
    }
}
