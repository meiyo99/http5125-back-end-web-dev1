using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1Controller : ControllerBase
    {

        /// <summary>
        /// Calculate the final score based on the provided point system.
        /// </summary>
        /// <param name="Deliveries"></param>
        /// <param name="Collisions"></param>
        /// <returns>
        /// +50 points for each delivery, -10 points for each collision, and +500 points if there are more deliveries than collisions.
        /// </returns>
        /// <example>
        /// POST: api/J1/Delivedroid
        /// Headers: Content-Type: application/x-www-form-urlencoded
        /// POST DATA: Deliveries=2&Collisions=3 -> 70
        /// </example>
        /// <example>
        /// POST: /api/J1/Delivedroid
        /// Headers: Content-Type: application/x-www-form-urlencoded
        /// POST DATA: Deliveries=5&Collisions=2 -> 730
        /// </example>
        [HttpPost(template: "Delivedroid")]
        [Consumes("application/x-www-form-urlencoded")]
        public int Delivedroid([FromForm] int Deliveries, [FromForm] int Collisions)
        {
            int points = (Deliveries * 50) - (Collisions * 10);
            if(Deliveries > Collisions)
            {
                points = points + 500;
            }
            return points;
        }

        /// <summary>
        /// Take the temperature(B) as input and calculate atmospheric pressure(P) with the given formula.
        /// Also determine whether you are below sea level, at sea level, or above sea level.
        /// </summary>
        /// <param name="B"></param>
        /// <returns>
        /// atmospheric pressure(P) and -1, 0, 1 (for below sea level, at sea level, or above sea level, respectively).
        /// </returns>
        /// <example>
        /// GET: /api/J1/BoilingWater?B=102 -> 110, -1
        /// GET: /api/J1/BoilingWater?B=100 -> 110, 0
        /// GET: /api/J1/BoilingWater?B=99 -> 95, 1
        /// </example>
        [HttpGet(template:"BoilingWater")]
        public string BoilingWater(int B)
        {
            int P = (B * 5) - 400;
            if(P > 100)
            {
                return $"{P}, -1";
            }
            else if (P < 100)
            {
                return $"{P}, 1";
            }
            else
            { 
                return $"{P}, 0";
            }
        }
 
    }
}
