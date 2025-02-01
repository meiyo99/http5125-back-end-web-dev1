using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// We want to receive a date adjusted by a certain number of days given by the user.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>
        /// Returns a string of the current date in the format of yyyy-mm-dd, adjusted by days.
        /// </returns>
        /// <example>
        /// GET: api/q7/timemachine?days=1 -> 2025-02-02
        /// </example>
        [HttpGet(template:"timemachine")]
        public string Get(int days)
        {
            DateTime todaysDate = DateTime.Today;
            DateTime newDate = todaysDate.AddDays(days);
            return newDate.ToString("yyyy-MM-dd");
        }
    }
}
